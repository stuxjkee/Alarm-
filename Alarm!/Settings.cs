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
            if (Values.soundNotify) {
                checkSoundNotify.Checked = true;
                btnChoiceSound.Enabled = true;
                editSoundFilename.Text = Path.GetFileName(Values.soundFileName);
            } else {
                btnChoiceSound.Enabled = false;
            }
            editPercantage.Value = Values.percentage;
            editDelay.Value = Values.delay;
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
            btnSMSSettings.Enabled = checkSMS.Checked;
            if (checkSMS.Checked && Values.smscLogin == "") {
                SmsSettings wnd = new SmsSettings();
                wnd.ShowDialog();
                checkSMS.Checked = Values.smsNotify = editMobileNumber.Enabled = Values.smscLogin != "";
            }
        }

        private void editPercantage_ValueChanged(object sender, EventArgs e) {
            Values.percentage = (int)editPercantage.Value;
            Values.logger.Add("Percentage changed" + Values.percentage.ToString() + "%");
        }

        private void btnDevice_Click(object sender, EventArgs e) {
            Values.webcam.advanceSettings();
            Values.logger.Add("Device settings changed");
        }

        private void btnResolution_Click(object sender, EventArgs e) {
            Values.webcam.resolutionSettings();
            Values.logger.Add("Resolution settings changed");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            dialogFolderSelect.ShowDialog();
            Values.folderPath = editFolderSelect.Text = dialogFolderSelect.SelectedPath;
            Values.logger.Add("Imagaes path changed: " + editFolderSelect.Text);
        }

        private void btnCapture_Click(object sender, EventArgs e) {
            Values.forCompare = imgForCompare.Image;
            Helper.saveImg(imgForCompare.Image, Values.folderPath + "/toCompare.jpg");
            webcam.Stop();
            btnChange.Visible = true;
            btnCapture.Visible = false;
            btnFromFile.Visible = false;
            Values.forCompare = imgForCompare.Image;
            Values.logger.Add("Image for compare changed (captured)");
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
                Values.logger.Add("Image for compare changed (loaded)" + dialogFromFile.FileName);
            }
            dialogFromFile.Dispose();
            
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

        private void editDelay_ValueChanged(object sender, EventArgs e) {
            Values.delay = (int)editDelay.Value;
        }

        private void btnSMSSettings_Click(object sender, EventArgs e) {
            SmsSettings wnd = new SmsSettings();
            wnd.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) {
            Values.smsNotify = false;
            Values.emailNotify = false;
            if (checkEmail.Checked) {
                string exprEmail = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
                Match isMatch = Regex.Match(editEmail.Text, exprEmail, RegexOptions.IgnoreCase);
                if (!isMatch.Success) {
                    MessageBox.Show("Wrong e-mail");
                    editEmail.Text = "";
                    Values.smsNotify = false;
                    checkEmail.Checked = false;
                    editEmail_Leave(null, null);
                    e.Cancel = true;

                } else {
                    Values.email = editEmail.Text;
                    Values.emailNotify = true;
                    Values.logger.Add("Email notify enabled");
                }
            }

            if (checkSMS.Checked) {

                string exprMobileNumber = "^((8|\\+3)[\\- ]?)?(\\(?\\d{3,4}\\)?[\\- ]?)?[\\d\\- ]{5,11}$";
                Match isMatch = Regex.Match(editMobileNumber.Text, exprMobileNumber);
                if (!isMatch.Success) {
                    MessageBox.Show("Wrong mobile number");
                    editMobileNumber.Text = "";
                    Values.smsNotify = false;
                    checkSMS.Checked = false;
                    editMobileNumber_Leave(null, null);
                    e.Cancel = true;
                } else {
                    if (editMobileNumber.Text[0] == '+') {
                        editMobileNumber.Text = editMobileNumber.Text.Substring(1, editMobileNumber.Text.Length - 1);
                    } else if (editMobileNumber.Text[0] == '8') {
                        editMobileNumber.Text = '3' + editMobileNumber.Text;
                    } else if (editMobileNumber.Text[0] == '0') {
                        editMobileNumber.Text = "38" + editMobileNumber.Text;
                    }
                    Values.mobile = editMobileNumber.Text;
                    Values.smsNotify = true;
                    Values.logger.Add("SMS notify enabled");
                }
            }
        }

        private void btnChoiceSound_Click(object sender, EventArgs e) {
            dialogSoundSelect.Filter = "Music Files (*.mp3)|*.mp3";
            if (dialogSoundSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Values.soundFileName = dialogSoundSelect.FileName;
                Values.soundNotify = true;
                editSoundFilename.Text = dialogSoundSelect.SafeFileName;
                btnChoiceSound.Enabled = true;
            } else if (!Values.soundNotify) {
                checkSoundNotify.Checked = false;
                btnChoiceSound.Enabled = false;
            }
        }

        private void checkSoundNotify_CheckedChanged(object sender, EventArgs e) {
            if (checkSoundNotify.Checked && !Values.soundNotify) {
                btnChoiceSound_Click(null, null);
            } else {
                Values.soundNotify = false;
                btnChoiceSound.Enabled = false;
            }
        }
              
    }
}
