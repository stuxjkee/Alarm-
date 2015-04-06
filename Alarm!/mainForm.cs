using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_ {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        public static void DANGER() {
            MessageBox.Show("DANGER");
        }


        private void mainForm_Load(object sender, EventArgs e) {
            Values.webcam = new WebCam();
            Values.webcam.InitializeWebCam(ref imgVideo);
            Values.webcam.Start();
            Values.imgVideo = imgVideo;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            btnSettings_Click(btnSettings, null);
            if (Values.forCompare == null) {
                MessageBox.Show("Error. Image for comparing not found");
            } else {
                Monitor.Start();
                btnStart.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            Monitor.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            Monitor.Continue();
        }


        private void btnSettings_Click(object sender, EventArgs e) {
            Settings wnd = new Settings();
            
            wnd.ShowDialog();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Monitor.Exit();
        }

        

        
    }
}
