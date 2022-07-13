namespace Logger
{
    public class LoggerConfiguration
    {
        public LoggerConfiguration(Level level)
        {
            this.SetLogLevel(level);
            this._levelToSinkMappings = new Dictionary<Level, List<ISinkHandler>>();
        }

        public Level Level {get; private set;}

        private Dictionary<Level, List<ISinkHandler>> _levelToSinkMappings;

        public void SetLogLevel(Level level) => this.Level = level;

        public IList<ISinkHandler> GetSinksForLevel(Level level)
        {
            IList<ISinkHandler> sinks = new List<ISinkHandler>();
            if (this._levelToSinkMappings.ContainsKey(level))
                sinks = this._levelToSinkMappings[level];

            return sinks;
        }

        public void SetSinkForLevel(Level level, ISinkHandler sinkHandler)
        {
            if (!this._levelToSinkMappings.ContainsKey(level))
                this._levelToSinkMappings.Add(level, new List<ISinkHandler>());

            this._levelToSinkMappings[level].Add(sinkHandler);
        }
    }
}