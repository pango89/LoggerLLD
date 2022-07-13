namespace Logger
{
    public class Logger
    {
        public Logger(LoggerConfiguration configuration)
        {
            this._configuration = configuration;
        }

        private LoggerConfiguration _configuration;

        public void Log(Level level, string ns, string message)
        {
            if (level > this._configuration.Level)
                return;

            foreach (ISinkHandler sink in this._configuration.GetSinksForLevel(level))
            {
                sink.WriteMessage(ns, message);
            }
        }
    }
}