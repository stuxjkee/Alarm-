using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm_ {
    public partial class DangerForm : Form {
        public DangerForm() {
            TopMost = true;

            InitializeComponent();
        }

        SoundPlayer sp;
        Flasher flasher;

        private void DangerForm_Load(object sender, EventArgs e) {
            sp = new SoundPlayer();
            flasher = new Flasher(labelDanger);
            flasher.Start();
            if (Values.soundNotify) {     
                if (Values.soundFileName != "Default") {
                    sp = new SoundPlayer();
                    sp.SoundLocation = Values.soundFileName;
                } else {
                    sp = new SoundPlayer(Properties.Resources.alarm);
                }
                sp.PlayLooping();
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            flasher.Stop();
            sp.Stop();
            Values.mainFormPtr.Stop();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            flasher.Stop();
            sp.Stop();
            Monitor.Start();
            this.Close();
        }

        private void labelDanger_Click(object sender, EventArgs e) {

        }
        
    }
}
