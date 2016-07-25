namespace Engine.SingletonPattern.PatternVersion_StaticInitialization
{
    public sealed class Logger
    {
        private static readonly Logger _logger = new Logger();

        private Logger()
        {
        }

        public static Logger GetLogger()
        {
            return _logger;
        }

        public void WriteMessage(string message)
        {
        }
    }
}