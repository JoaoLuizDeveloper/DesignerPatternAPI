namespace DesignerPattern.Infrastructure.Services
{
    // Singleton Logger class for logging messages
    // Serve pode ser usado para registrar logs no console em apenas uma instância, Dessa forma atende ao padrão Singleton.
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        public static Logger Instance => _instance;

        private Logger() { }

        // Criando Log no console
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}