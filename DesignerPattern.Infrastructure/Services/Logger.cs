namespace DesignerPattern.Infrastructure.Services
{
    // Singleton Logger class for logging messages
    // It can be used to log messages to the console using a single instance. This follows the Singleton pattern.
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        public static Logger Instance => _instance;

        private Logger() { }

        // Creating log output in the console
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}