namespace DesignerPattern.Infrastructure.Services
{
    // Singleton Logger class for logging messages
    // Essa classe serve para registrar mensagens de log no console em apenas uma instância, Dessa forma atende ao padrão Singleton.
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        public static Logger Instance => _instance;

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}