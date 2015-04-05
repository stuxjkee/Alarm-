using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Alarm_ {
    class Values {
        public static WebCam webcam;
        public static string folderPath = Directory.GetCurrentDirectory()+"\\monitor";
        public static int percentage = 10;
        public static int delay = 2;
        public static Image forCompare = null;
        public static string email;
        public static string mobile;
        public static bool smsNotify = false;
        public static bool emailNotify = false;
    }
}
