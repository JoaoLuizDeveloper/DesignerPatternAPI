using DesignerPattern.Application.Strategies;

namespace DesignerPattern.Application.Services
{
    public class TaxCalculator
    {
        private readonly ITaxStrategy _strategy;

        // Construtor que recebe uma estratégia de cálculo de imposto
        public TaxCalculator(ITaxStrategy strategy)
        {
            _strategy = strategy;
        }

        // Método que calcula o imposto com a estratégia BR ou USA
        public decimal CalculateTax(decimal amount) => _strategy.Calculate(amount);
    }
}