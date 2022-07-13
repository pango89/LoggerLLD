namespace Logger
{
    public class FileSinkHandler : ISinkHandler
    {
        private string _path;
        private string _timestampFormat;

        public FileSinkHandler(string path, string timestampFormat)
        {
            this._path = path;
            this._timestampFormat = timestampFormat;
        }

        public void WriteMessage(string ns, string message)
        {
            // Open File
            // Write to File
            // Close File
            Console.WriteLine("File Sink - {0} - {1} - {2}", new DateTime(), ns, message);
        }
    }
}