namespace DesignerPattern.Application.Strategies
{
    public class BrazilTax : ITaxStrategy
    {
        public decimal Calculate(decimal amount) => amount * 0.15m;
    }
}
