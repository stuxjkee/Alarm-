using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Threading;

namespace Alarm_ {
    class Helper {
        public static void saveImg(System.Drawing.Image img, string fileName) {
            /*FileStream fstream = new FileStream(fileName, FileMode.Create);
            img.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();*/

            if (!Directory.Exists(Values.folderPath)) {
                Directory.CreateDirectory(Values.folderPath);
            }

            Thread.Sleep(500);

            using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
                img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }

        public static bool CheckForInternetConnection() {
            try {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com.ua")) {
                    return true;
                }
            } catch {
                return false;
            }
        }

     }
}
