using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3 {
    class FileIO {

        public void SaveToFile(string content, string path) {
            FileStream stream =
                new FileStream(path, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.WriteLine(content);
            }
        }
    }
}
