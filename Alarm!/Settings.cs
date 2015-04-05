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
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e) {
            editEmail_Leave(editEmail, null);
            editMobileNumber_Leave(editMobileNumber, null);
            editFolderSelect.Text = Values.folderPath;
        }

        private void editEmail_Leave(object sender, EventArgs e) {
            if (editEmail.Text.Length == 0) {
                editEmail.Text = "Enter your e-mail";
                editEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void editEmail_Enter(object sender, EventArgs e) {
            if (editEmail.Text == "Enter your e-mail") {
                editEmail.Text = "";
                editEmail.ForeColor = SystemColors.WindowText;
            }
        }


        private void editMobileNumber_Leave(object sender, EventArgs e) {
            if (editMobileNumber.Text.Length == 0) {
                editMobileNumber.Text = "Enter your mobile number";
                editMobileNumber.ForeColor = SystemColors.GrayText;
            }
        }

        private void editMobileNumber_Enter(object sender, EventArgs e) {
            if (editMobileNumber.Text == "Enter your mobile number") {
                editMobileNumber.Text = "";
                editMobileNumber.ForeColor = SystemColors.WindowText;
            }
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e) {
            Values.emailNotify = editEmail.Enabled = checkEmail.Checked;
        }

        private void checkSMS_CheckedChanged(object sender, EventArgs e) {
            Values.smsNotify = editMobileNumber.Enabled = checkSMS.Checked;
        }

        private void editPercantage_ValueChanged(object sender, EventArgs e) {
            var o = (NumericUpDown)sender;
            Values.percentage = (int)o.Value;
        }

        private void btnDevice_Click(object sender, EventArgs e) {
            Values.webcam.advanceSettings();
        }

        private void btnResolution_Click(object sender, EventArgs e) {
            Values.webcam.resolutionSettings();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            dialogFolderSelect.ShowDialog();
            Values.folderPath = editFolderSelect.Text = dialogFolderSelect.SelectedPath;
        }

        
        
        
    }
}
