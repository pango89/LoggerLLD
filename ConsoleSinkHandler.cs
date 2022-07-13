namespace Logger
{
    public class ConsoleSinkHandler : ISinkHandler
    {
        private string _timestampFormat;

        public ConsoleSinkHandler(string timestampFormat)
        {
            this._timestampFormat = timestampFormat;
        }

        public void WriteMessage(string ns, string message)
        {
            Console.WriteLine("Console Sink - {0} - {1} - {2}", new DateTime(), ns, message);
        }
    }
}