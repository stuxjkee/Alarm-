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
        public static Logger logger;
        public static WebCam webcam;
        public static string folderPath = Directory.GetCurrentDirectory()+"\\monitor";
        public static int percentage = 15;
        public static int delay = 3;
        public static Image forCompare = null;
        public static string email;
        public static string mobile;
        public static string soundFileName;
        public static bool smsNotify = false;
        public static bool emailNotify = false;
        public static bool soundNotify = false;
        public static PictureBox imgVideo;
        public static int framesCnt = 3;
        public static string smscLogin = "";
        public static string smscPassword = "";
    }
}
