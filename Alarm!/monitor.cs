using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using XnaFan.ImageComparison;
using System.Drawing;

namespace Alarm_ {
    class Monitor {
        public static bool isRunnung = true;
        static Thread monitorThread = new Thread(monitor);
        public static void Start() {         
            monitorThread.Start();          
        }
        static void monitor() {
            while (isRunnung) {
                try {
                    Thread.Sleep(Values.delay * 1000);
                } catch (ThreadInterruptedException ignored) { }
                Image img = Values.imgVideo.Image;
                float diff = 0;
                try {
                    diff = img.PercentageDifference(Values.forCompare);
                } catch (InvalidOperationException ignored) {}
                if (diff * 100 > Values.percentage) {
                    Values.logger.Add("Possible danger (" + (diff * 100).ToString() + "%)");
                    mainForm.DANGER();
                    string filename = Values.folderPath + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
                    
                    Helper.saveImg(img, filename);
                    if (Values.smsNotify) {
                        SMSC smsc = new SMSC();
                        smsc.send_sms(Values.mobile,
                        "Possible danger at " + DateTime.Now.ToString("dd MMM HH:mm:ss") + "Please check your email",
                        0, "", 0, 0, "Alarm");
                        Values.logger.Add("SMS notify sended");
                    }

                    if (Values.emailNotify) {
                        List<string> filenames = new List<string>();
                        filenames.Add(filename);
                        Mail.email_send(filenames);
                        filenames.RemoveAt(0);
                        Values.logger.Add("First e-mail sended");
                        for (int i = 0; i < Values.framesCnt; i++) {
                            filename = Values.folderPath + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
                            Helper.saveImg(img, filename);
                            img = Values.imgVideo.Image;
                            filenames.Add(filename);
                            try {
                                Thread.Sleep(5 * 1000);
                            } catch (ThreadInterruptedException ignored) { }
                        }
                        Mail.email_send(filenames);
                        Values.logger.Add("Second email with" + Values.framesCnt.ToString() + " frames sended");
                    }

                    

                } 
            }
        }
        public static void Stop() {
            Values.webcam.Stop();
            isRunnung = false;
        }
        public static void Continue() {
            Values.webcam.Continue();
            isRunnung = true;
        }
        public static void Exit() {
            Stop();
            try {
                monitorThread.Interrupt();
            } catch (ThreadInterruptedException ignored) { }
        }
        
    }
}
