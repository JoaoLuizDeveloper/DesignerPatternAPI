namespace DesignerPattern.Application.Strategies
{
    public class BrazilTax : ITaxStrategy
    {
        // Performs tax calculation for Brazil
        public decimal Calculate(decimal amount) => amount * 0.15m;
    }
}
