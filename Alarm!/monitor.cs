using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

using AForge.Vision.Motion;

namespace Alarm_ {
    class Monitor {
        static Thread monitorThread;

        static MotionDetector motionDetector = GetDefaultMotionDetector();
        static Bitmap curFrame;

        public static void Start() {
            monitorThread = new Thread(monitor);
            monitorThread.Start();          
        }

        private static void monitor() {
            while (monitorThread.IsAlive) {
                Thread.Sleep(500);
                curFrame = Values.curFrame;
                if (motionDetector.ProcessFrame(curFrame) > Values.diff) {
                    //MessageBox.Show("ALARM");
                    ALARM();
                }
            }
        }

        public static MotionDetector GetDefaultMotionDetector() {
            AForge.Vision.Motion.IMotionDetector detector = null;
            AForge.Vision.Motion.IMotionProcessing processor = null;
            AForge.Vision.Motion.MotionDetector motionDetector = null;

            //detector = new AForge.Vision.Motion.TwoFramesDifferenceDetector()
            //{
            //  DifferenceThreshold = 15,
            //  SuppressNoise = true
            //};

            //detector = new AForge.Vision.Motion.CustomFrameDifferenceDetector()
            //{
            //  DifferenceThreshold = 15,
            //  KeepObjectsEdges = true,
            //  SuppressNoise = true
            //};

            detector = new AForge.Vision.Motion.SimpleBackgroundModelingDetector() {
                DifferenceThreshold = 10,
                FramesPerBackgroundUpdate = 10,
                KeepObjectsEdges = true,
                MillisecondsPerBackgroundUpdate = 0,
                SuppressNoise = true
            };

            processor = new AForge.Vision.Motion.GridMotionAreaProcessing()
            {
                HighlightColor = System.Drawing.Color.Red,
                HighlightMotionGrid = true,
                GridWidth = 100,
                GridHeight = 100,
                MotionAmountToHighlight = 100F
            };

            /*processor = new AForge.Vision.Motion.BlobCountingObjectsProcessing() {
                HighlightColor = System.Drawing.Color.Red,
                HighlightMotionRegions = true,
                MinObjectsHeight = 10,
                MinObjectsWidth = 10
            };*/

            motionDetector = new AForge.Vision.Motion.MotionDetector(detector, processor);

            return (motionDetector);
        }

        private static void SendSMS() {
            if (!Helper.CheckForInternetConnection()) {
                Values.logger.Add("Lost inet connection");
                return;
            } 
            SMSC smsc = new SMSC();
            smsc.send_sms(Values.mobile,
            "Possible danger at " + DateTime.Now.ToString("dd MMM HH:mm:ss") + "Please check your email",
            0, "", 0, 0, "Alarm");
            Values.logger.Add("SMS notify sended");
        }

        private static void SendEmail() {
            if (!Helper.CheckForInternetConnection()) {
                Values.logger.Add("Lost inet connection");
                return;
            }
            Image img = Values.curFrame;
            String filename = Values.folderPath + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
            Helper.saveImg(img, filename);
            List<string> filenames = new List<string>();
            filenames.Add(filename);
            Mail.email_send(filenames);
            filenames.RemoveAt(0);
            Values.logger.Add("First e-mail sended");
            
            for (int i = 0; i < Values.framesCnt; i++) {
                filename = Values.folderPath + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
                Helper.saveImg(img, filename);
                img = Values.curFrame;
                filenames.Add(filename);
                try {
                    Thread.Sleep(5 * 1000);
                } catch (ThreadInterruptedException ignored) { }
            }
            Mail.email_send(filenames);
            Values.logger.Add("Second email with" + Values.framesCnt.ToString() + " frames sended");
        }

        private static void ALARM() {
            Image img = Values.curFrame;
            Values.logger.Add("Possible danger at " + DateTime.Now.ToString("dd MMM HH:mm:ss"));
            mainForm.DANGER();
            string imageFilename = Values.folderPath + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";

            Helper.saveImg(img, imageFilename);
            if (Values.smsNotify) {
                
                Thread smsThread = new Thread(SendSMS);
                smsThread.IsBackground = true;
                smsThread.Start();    
            }

            if (Values.emailNotify) {
                
                    Thread emailThread = new Thread(SendEmail);
                    emailThread.IsBackground = true;
                    emailThread.Start();
                
            }

            Thread showDangerFormThread = new Thread(showDangerForm);
            showDangerFormThread.IsBackground = true;
            showDangerFormThread.Start();
            Exit();
        }

        static void showDangerForm() {
            DangerForm wnd = new DangerForm();
            wnd.ShowDialog();
        }

        public static void Stop() {
            try {
                monitorThread.Abort();
            } catch (ThreadAbortException ignored) { }
        }
        
        public static void Exit() {
            motionDetector = GetDefaultMotionDetector();
            if (monitorThread != null && monitorThread.IsAlive) {
                Stop();
            }
        }
        
    }
}
