using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Alarm_ {
    public partial class RemoteCameraForm : Form {
        public RemoteCameraForm() {
            InitializeComponent();
        }
        public string url;
        public bool OK = false;
        public int type = 1;
        private void btnOk_Click(object sender, EventArgs e) {
            string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            bool isUri = reg.IsMatch(editUrl.Text);
            
            if (!isUri) {
                MessageBox.Show("Wrong url");
                OK = false;
                this.Close();

            } else {
                url = editUrl.Text;
                OK = true;
                type = editType.SelectedIndex;
                this.Close();
            }
            
        }

        private void RemoteCameraForm_Load(object sender, EventArgs e) {
            editType.SelectedIndex = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            OK = false;
            this.Close();
        }
    }
}
