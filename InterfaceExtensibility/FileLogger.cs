using System.IO;

namespace InterfaceExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }


        public void LogError(string message)
        {
            Writetofile(message, LogTypes.ERROR.ToString());
        }

        public void LogInfo(string message)
        {
            Writetofile(message, LogTypes.INFO.ToString());
        }

        private void Writetofile(string message,string logType)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {

                writer.WriteLine($"{logType} : {message}");
            }
        }
    }
}
