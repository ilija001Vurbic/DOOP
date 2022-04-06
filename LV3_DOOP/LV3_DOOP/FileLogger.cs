using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV3_DOOP
{
    class FileLogger
    {
        private static FileLogger instance;
        private string filePath;
        private FileLogger()
        {
            filePath = "DefaultFile.txt";
        }
        public static FileLogger GetInstance()
        {
            if (instance == null)
            {
                return new FileLogger();
            }
            return instance;
        }
        public void SetFilePath(string path)
        {
            filePath = path;
        }
        public string GetFilePath()
        {
            return filePath;
        }
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
