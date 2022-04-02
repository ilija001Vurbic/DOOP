using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_DOOP
{
    class FileLogger : ILogger
    {
        private string filePath;
        public FileLogger(string path)
        {
            filePath = path;
        }
        public void Log(ILoggable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
    }
}
