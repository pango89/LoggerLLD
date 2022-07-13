namespace Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoggerConfiguration config = new LoggerConfiguration(Level.warn);
            config.SetSinkForLevel(Level.debug, new ConsoleSinkHandler("YYYY-MM-DD"));

            config.SetSinkForLevel(Level.info, new ConsoleSinkHandler("YYYY-MM-DD"));
            config.SetSinkForLevel(Level.info, new FileSinkHandler("path", "YYYY-MM-DD"));

            config.SetSinkForLevel(Level.error, new ConsoleSinkHandler("YYYY-MM-DD"));
            config.SetSinkForLevel(Level.error, new FileSinkHandler("path", "YYYY-MM-DD"));
            config.SetSinkForLevel(Level.error, new DatabaseSinkHandler("YYYY-MM-DD"));

            Logger logger = new Logger(config);
            logger.Log(Level.info, "NS1", "This is message 1");
            logger.Log(Level.error, "NS1", "This is message 2");
        }
    }
}
