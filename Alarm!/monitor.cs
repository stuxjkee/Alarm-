using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_ {
    class Monitor {
        public static void Start() {

        }
        public static void Stop() {
            Values.webcam.Stop();
        }
        public static void Continue() {
            Values.webcam.Continue();
        }
    }
}
