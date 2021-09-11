using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CodingKatas.Ardalis.NSFileLogger
{
    public class FileLogger
    {
        private readonly IDateTime _dateTime;
        private readonly IFileNameStrategy _fileNameStrategy;

        public FileLogger() : this(new SystemDateTime(), new DefaultFileNameStrategy())
        {
        }
        public FileLogger(IDateTime dateTime, IFileNameStrategy fileNameStrategy)
        {
            _dateTime = dateTime;
            _fileNameStrategy = fileNameStrategy;
        }
        public void Log(string message)
        {
            string fileName = _fileNameStrategy.GetFileName(_dateTime.Now);
            using (var writer = File.AppendText(fileName))
            {
                string dateString = _dateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine($"{dateString} {message}");
            }
        }
    }
}
