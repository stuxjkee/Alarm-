using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XnaFan.ImageComparison;

namespace Alarm_ {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e) {
            Values.webcam = new WebCam();
            Values.webcam.InitializeWebCam(ref imgVideo);
            Values.webcam.Start();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            btnSettings_Click(btnSettings, null);
            if (Values.forCompare == null) {
                MessageBox.Show("Error. Image for comparing not found");
            } else {
                Monitor.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            Monitor.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            Monitor.Continue();
        }

        private void captureBtn_Click(object sender, EventArgs e) {
            Helper.saveImg(imgVideo.Image, Values.folderPath + DateTime.Now.ToString("HH.mm.ss") + ".jpg");
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            Settings wnd = new Settings();
            
            wnd.ShowDialog();
        }

        
    }
}
