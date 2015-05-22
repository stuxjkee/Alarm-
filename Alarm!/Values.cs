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
        public static mainForm mainFormPtr;
        public static bool intertedConnection = false;
        public static Logger logger;
        public static bool firstStart = true;
        public static string folderPath = Directory.GetCurrentDirectory()+"\\monitor";
        public static double diff = 0.02;
        public static string email;
        public static string mobile;
        public static string soundFileName = "Default";
        public static bool monitoringEnabled = true;
        public static bool smsNotify = false;
        public static bool emailNotify = false;
        public static bool soundNotify = true;
        public static Bitmap curFrame;
        public static int framesCnt = 3;
        public static string smscLogin = "";
        public static string smscPassword = "";
        public static string REMOTE_BOX_STRING = "Use remote/ip camera";
    }
}
