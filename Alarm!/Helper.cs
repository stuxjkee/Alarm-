using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


namespace Alarm_ {
    class Helper {
        public static void saveImg(System.Drawing.Image img, string fileName) {              
                FileStream fstream = new FileStream(fileName, FileMode.Create);
                img.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }
        }
}
