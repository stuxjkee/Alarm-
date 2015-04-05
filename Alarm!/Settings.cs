using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace Alarm_ {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }
        WebCam webcam;
        private void Settings_Load(object sender, EventArgs e) {
            editEmail_Leave(editEmail, null);
            editMobileNumber_Leave(editMobileNumber, null);
            dialogFolderSelect.SelectedPath = editFolderSelect.Text = Values.folderPath;
            if (Values.forCompare == null) {
                btnChange_Click(btnChange, null);
            } else {
                imgForCompare.Image = Values.forCompare;
            }
            if (Values.emailNotify) {
                checkEmail.Checked = true;
                editEmail.Text = Values.email;
            }
            if (Values.smsNotify) {
                checkSMS.Checked = true;
                editMobileNumber.Text = Values.mobile;
            }
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

        private void btnCapture_Click(object sender, EventArgs e) {
            Values.forCompare = imgForCompare.Image;
            Helper.saveImg(imgForCompare.Image, Values.folderPath + "/toCompare.jpg");
            webcam.Stop();
            btnChange.Visible = true;
            btnCapture.Visible = false;
            btnFromFile.Visible = false;
            Values.forCompare = imgForCompare.Image;
        }

        private void btnChange_Click(object sender, EventArgs e) {
            btnChange.Visible = false;
            btnFromFile.Visible = true;
            btnCapture.Visible = true;
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgForCompare);
            webcam.Start();
        }

        private void btnFromFile_Click(object sender, EventArgs e) {
            dialogFromFile.InitialDirectory = Values.folderPath;
            dialogFromFile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (dialogFromFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                webcam.Stop();
                btnChange.Visible = true;
                btnCapture.Visible = false;
                btnFromFile.Visible = false;
                using (FileStream fs = new FileStream(dialogFromFile.FileName, FileMode.Open, FileAccess.Read)) {
                    using (Image img = Image.FromStream(fs)) {
                        imgForCompare.Image = Values.forCompare = (Image)img.Clone();
                    }
                }
            }
            dialogFromFile.Dispose();
            
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e) {
            Values.smsNotify = false;
            Values.emailNotify = false;
            if (checkEmail.Checked) {
                string exprEmail = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
                Match isMatch = Regex.Match(editEmail.Text, exprEmail, RegexOptions.IgnoreCase);
                if (!isMatch.Success) {
                    MessageBox.Show("Wrong e-mail");
                    editEmail.Text = "";
                    Values.smsNotify = false;
                } else {
                    Values.email = editEmail.Text;
                    Values.emailNotify = true;
                }
            } 

            if (checkSMS.Checked) {

                string exprMobileNumber = "^((8|\\+3)[\\- ]?)?(\\(?\\d{3,4}\\)?[\\- ]?)?[\\d\\- ]{5,11}$";
                Match isMatch = Regex.Match(editMobileNumber.Text, exprMobileNumber);
                if (!isMatch.Success) {
                    MessageBox.Show("Wrong mobile number");
                    editMobileNumber.Text = "";
                    Values.smsNotify = false;
                } else {
                    Values.mobile = editMobileNumber.Text;
                    Values.smsNotify = true;
                }
            }
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            var o = (NumericUpDown)sender;
            Values.delay = (int)o.Value;
        }
              
    }
}
