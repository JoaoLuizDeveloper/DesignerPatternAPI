using DesignerPattern.Application.Strategies;

namespace DesignerPattern.Application.Services
{
    public class TaxCalculator
    {
        private readonly ITaxStrategy _strategy;

        public TaxCalculator(ITaxStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateTax(decimal amount) => _strategy.Calculate(amount);
    }
}