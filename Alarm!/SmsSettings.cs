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
    public partial class SmsSettings : Form {
        public SmsSettings() {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            SMSC smsc = new SMSC();
            SMSC.SMSC_LOGIN = editUsername.Text;
            SMSC.SMSC_PASSWORD = editPassword.Text;
            string result = smsc.get_balance();
            if (result == "") {
                MessageBox.Show("Invalid username or password", "Error");
                Values.smscLogin = SMSC.SMSC_LOGIN = editUsername.Text = "";
                Values.smscPassword = SMSC.SMSC_PASSWORD = editPassword.Text = "";
            } else {
                MessageBox.Show("Balance: " + smsc.get_balance(), "Success!");
                Values.smscLogin = editUsername.Text;
                Values.smscPassword = editPassword.Text;
                this.Close();
            }
        }

        private void SmsSettings_Load(object sender, EventArgs e) {
            if (Values.smscLogin != "") {
                editUsername.Text = Values.smscLogin;
            }
            if (Values.smscPassword != "") {
                editPassword.Text = Values.smscPassword;
            }
        }
    }
}
