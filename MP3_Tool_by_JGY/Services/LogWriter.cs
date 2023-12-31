using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class LogWriter
    {

        public void checkFolder(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        public void createLogFile(string path)
        {
            File.Create(path);
        }

        public async Task Write(string line, string path)
        {
            using (StreamWriter w = File.AppendText(path))
            {
                await w.WriteLineAsync(line); // no need to close and etc when async
            }
        }
    }
}