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

/*
 * UPDATES:
 * Add sound notify
 * Add Update capture image
 * Add UI notify
 * */

namespace Alarm_ {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        public static void DANGER() {

        }
        private void mainForm_Load(object sender, EventArgs e) {
            labelMonitoring.Parent = imgVideo;
            labelMonitoring.BackColor = Color.Transparent;
            labelDanger.Parent = imgVideo;
            labelDanger.BackColor = Color.Transparent;
            Values.webcam = new WebCam();
            Values.webcam.InitializeWebCam(ref imgVideo);
            Values.webcam.Start();
            Values.imgVideo = imgVideo;
            Values.logger = new Logger();
        }

        Flasher monitoringFlasher;
        private void btnStart_Click(object sender, EventArgs e) {
            btnSettings_Click(btnSettings, null);
            if (Values.forCompare == null) {
                MessageBox.Show("Error. Image for comparing not found");
            } else {
                monitoringFlasher = new Flasher(labelMonitoring);
                monitoringFlasher.Start();
                Monitor.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                Values.logger.Add("MONITOR STARTED");
            }
        }

        

        private void btnStop_Click(object sender, EventArgs e) {
            btnStop.Enabled = false;
            btnContinue.Enabled = true;
            monitoringFlasher.Stop();
            labelMonitoring.Visible = false;
            Monitor.Stop();
            Values.logger.Add("MONITOR STOPED");
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            monitoringFlasher.Start();
            btnStop.Enabled = true;
            btnContinue.Enabled = false;
            Monitor.Continue();
            Values.logger.Add("MONITOR CONTINUED");
        }


        private void btnSettings_Click(object sender, EventArgs e) {
            Settings wnd = new Settings();
            
            wnd.ShowDialog();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Values.logger.Save();
            Monitor.Exit();
        }

        

        
    }
}
