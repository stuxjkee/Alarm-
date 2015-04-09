using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Alarm_ {
    class Logger {
        private List<string> log;
        public Logger() {
            log = new List<string>();
            log.Add("Logger started");
        }
        public  void Add(string s) {
            log.Add(DateTime.Now.ToString("hh:MM:ss") + ":> " + s);
        }
        public  void Save() {
            using (StreamWriter sw = new StreamWriter(@"log.txt")) {
                foreach (string s in log) {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }
        public  void Erase() {
            log.RemoveRange(0, log.Count);
        }
    }
}
