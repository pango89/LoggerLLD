namespace Logger
{
    public class DatabaseSinkHandler : ISinkHandler
    {
        private string _timestampFormat;

        public DatabaseSinkHandler(string timestampFormat)
        {
            this._timestampFormat = timestampFormat;
        }

        public void WriteMessage(string ns, string message)
        {
            // Open DB Connection
            // Write
            // Close DB Connection

            Console.WriteLine("DB Sink - {0} - {1} - {2}", new DateTime(), ns, message);
        }
    }
}