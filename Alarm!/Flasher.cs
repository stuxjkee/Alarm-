using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Alarm_ {
    class Flasher {
        Label label;
        Thread thread;
        bool isRunning = true;
        public Flasher(Label label) {
            this.label = label;
        }
        public void Start() {
            isRunning = true;
            thread = new Thread(Flash);
            thread.IsBackground = true;
            thread.Start();
        }
        public void Flash() {
            while (isRunning) {
                try {
                    Thread.Sleep(1000);
                } catch (ThreadInterruptedException ignored) {
                } catch (ThreadAbortException ignored) { }
                
                if (label.InvokeRequired) {
                    label.BeginInvoke(new Action<bool>((fl) => label.Visible = fl), !label.Visible);
                } else {
                    label.Visible = !label.Visible;
                }
            }
        }
        public void Stop() {
            isRunning = false;
            thread.Abort();
            if (label.InvokeRequired) {
                label.BeginInvoke(new Action(() => label.Visible = false));
            } else {
                label.Visible = false;
            }       
        }
    }
}
