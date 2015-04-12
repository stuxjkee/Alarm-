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
        private void Settings_Load(object sender, EventArgs e) {
            editEmail_Leave(editEmail, null);
            editMobileNumber_Leave(editMobileNumber, null);
            dialogFolderSelect.SelectedPath = editFolderSelect.Text = Values.folderPath;

            if (Values.soundFileName == "Default") {
                editSoundFilename.Text = "Default";
            } else {
                editSoundFilename.Text = Path.GetFileName(Values.soundFileName);
            }
            Values.intertedConnection = Helper.CheckForInternetConnection();

            if (Values.intertedConnection) {
                labelInternetConnection.Text = "Connected to internet";
                labelInternetConnection.ForeColor = Color.Green;
            } else {
                labelInternetConnection.Text = "Not connected to internet";
                labelInternetConnection.ForeColor = Color.Red;
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
            
            editDiff.Value = (int)(Values.diff*100);
            labelDiff.Text = Values.diff.ToString();

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
            if (checkEmail.Checked && !Values.intertedConnection) {
                MessageBox.Show("Requires internet connection");
                checkEmail.Checked = false;
                return;
            }
            Values.emailNotify = editEmail.Enabled = checkEmail.Checked;
        }

        private void checkSMS_CheckedChanged(object sender, EventArgs e) {
            if (checkSMS.Checked && !Values.intertedConnection) {
                MessageBox.Show("Requires internet connection");
                checkSMS.Checked = false;
                return;
            }
            Values.smsNotify = editMobileNumber.Enabled = checkSMS.Checked;
            btnSMSSettings.Enabled = checkSMS.Checked;
            if (checkSMS.Checked && Values.smscLogin == "") {
                SmsSettings wnd = new SmsSettings();
                wnd.ShowDialog();
                checkSMS.Checked = Values.smsNotify = editMobileNumber.Enabled = Values.smscLogin != "";
            }
        }

        private void editPercantage_ValueChanged(object sender, EventArgs e) {
            Values.diff = (int)editDiff.Value;
            Values.logger.Add("Percentage changed" + Values.diff.ToString() + "%");
        }

        private void btnDevice_Click(object sender, EventArgs e) {
           // Values.webcam.advanceSettings();
            Values.logger.Add("Device settings changed");
        }

        private void btnResolution_Click(object sender, EventArgs e) {
            //Values.webcam.resolutionSettings();
            Values.logger.Add("Resolution settings changed");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            dialogFolderSelect.ShowDialog();
            Values.folderPath = editFolderSelect.Text = dialogFolderSelect.SelectedPath;
            Values.logger.Add("Imagaes path changed: " + editFolderSelect.Text);
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

            if (checkSoundNotify.Checked) {
                if (!File.Exists(Values.soundFileName) && Values.soundFileName != "Default") {
                    checkSoundNotify.Checked = false;
                    Values.soundNotify = false;
                    editSoundFilename.Text = "";
                    MessageBox.Show("Wrong sound file");
                    e.Cancel = true;
                }
            }

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
            dialogSoundSelect.Filter = "Sound Files (*.wav)|*.wav";
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
            if (checkSoundNotify.Checked) {
                btnChoiceSound.Enabled = true;
                editSoundFilename.Text = Values.soundFileName;
                Values.soundNotify = true;
            } else {
                btnChoiceSound.Enabled = false;
                Values.soundNotify = false;
            }
        }

        private void editDiff_Scroll(object sender, EventArgs e) {
            Values.diff = (double)(editDiff.Value / 100.0);
            labelDiff.Text = Values.diff.ToString();
        }
              
    }
}
