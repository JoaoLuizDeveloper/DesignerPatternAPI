using DesignerPattern.Application.Strategies;

namespace DesignerPattern.Application.Services
{
    public class TaxCalculator
    {
        private readonly ITaxStrategy _strategy;

        // Constructor that receives a tax calculation strategy
        public TaxCalculator(ITaxStrategy strategy)
        {
            _strategy = strategy;
        }

        // Method that calculates the tax using the BR or USA strategy
        public decimal CalculateTax(decimal amount) => _strategy.Calculate(amount);
    }
}