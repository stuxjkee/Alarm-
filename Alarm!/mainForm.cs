using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using AForge.Video;
using AForge.Video.DirectShow;


namespace Alarm_ {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource;

        bool monitorStarted = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void DANGER() {

        }

        private void mainForm_Load(object sender, EventArgs e) {
            Values.mainFormPtr = this;
            Values.logger = new Logger();

            labelMonitoring.Parent = imgVideo;
            labelMonitoring.BackColor = Color.Transparent;

            

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            try {
                if (videoDevices.Count == 0) {
                    throw new ApplicationException();
                }
                foreach (FilterInfo device in videoDevices) {
                    boxDevices.Items.Add(device.Name);
                }
                boxDevices.SelectedIndex = 0;
                videoSource = new VideoCaptureDevice();
                CameraStart();
            } catch (ApplicationException ex) {
                MessageBox.Show("Video sources are not found");
                this.Close();
            }

           

        }

        

        private void CameraStop() {
            if (videoSource != null) {
                videoSource.Stop();
                imgVideo.Image = null;
                imgVideo.Invalidate();
            }
        }

        private void CameraStart() {
            videoSource = new VideoCaptureDevice(videoDevices[boxDevices.SelectedIndex].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            try {
                Values.curFrame = (Bitmap)eventArgs.Frame.Clone();
                imgVideo.Image = (Bitmap)eventArgs.Frame.Clone();
            } catch (InvalidOperationException ignored) { }
        }

        Flasher monitoringFlasher;
        private void btnStart_Click(object sender, EventArgs e) {
            if (!monitorStarted) {
                btnStart.Image = Properties.Resources.pause;
                
                monitorStarted = true;
                Start();
            } else {
                btnStart.Image = Properties.Resources.play;
                monitorStarted = false;
                Stop();
            }
        }


        public void Start() {
            if (Values.firstStart) {
                Values.firstStart = false;
                btnSettings_Click(btnSettings, null);
            }
            if (Values.monitoringEnabled) {
                monitoringFlasher = new Flasher(labelMonitoring);
                monitoringFlasher.Start();
                Monitor.Start();
                Values.logger.Add("MONITOR STARTED");
            }
            Values.logger.Add("Camera started");
        }

        public void Stop() {
            monitoringFlasher.Stop();
            if (labelMonitoring.InvokeRequired) {
                labelMonitoring.BeginInvoke(new Action(() => labelMonitoring.Visible = false));
            } else {
                labelMonitoring.Visible = false;
            }
            if (btnStart.InvokeRequired) {
                btnStart.BeginInvoke(new Action(() => btnStart.Image = Properties.Resources.play));
            } else {
                btnStart.Image = Properties.Resources.play;
            }
            Monitor.Stop();
            Values.logger.Add("MONITOR STOPED");
        }


        private void btnSettings_Click(object sender, EventArgs e) {
            Settings wnd = new Settings();
            wnd.ShowDialog();
        }

        

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void boxDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (videoSource != null && videoSource.IsRunning) {
                CameraStop();
                videoSource = new VideoCaptureDevice(videoDevices[boxDevices.SelectedIndex].MonikerString);
                CameraStart();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (videoSource.IsRunning) {
                videoSource.Stop();
            }
            Values.logger.Save();
            Monitor.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void btnCameraSettings_Click(object sender, EventArgs e) {
            try {
                videoSource.DisplayPropertyPage(this.Handle);
            } catch (Exception ignored) { }
        }        
    }
}
