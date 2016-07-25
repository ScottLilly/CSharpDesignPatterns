namespace Engine.SingletonPattern.NonPatternVersion
{
    public class Logger
    {
        // Make the constructor private, to force instantiation through the factory design pattern
        private Logger()
        {
        }

        // Factory method, that returns a new Logger object
        public static Logger GetLogger()
        {
            return new Logger();
        }

        // Pretend we're writing the message to a file here.
        public void WriteMessage(string message)
        {
        }
    }
}