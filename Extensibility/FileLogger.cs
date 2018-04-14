using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        //public void LogError(string message)
        //{
        //    using (var streamWriter = new StreamWriter(_path, true))
        //    {
        //        streamWriter.WriteLine("ERROR: " + message);
        //    }
            
            
        //}

        //public void LogInfo(string message)
        //{
        //    using (var streamWriter = new StreamWriter(_path, true))
        //    {
        //        streamWriter.WriteLine(message);
        //    }
        //}
        // For DRY (don't repeat yourself) it is better not to duplicate code in LogInfo and LogError

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }
        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
    }
}