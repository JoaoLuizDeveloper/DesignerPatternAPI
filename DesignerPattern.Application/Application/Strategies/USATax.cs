namespace DesignerPattern.Application.Strategies
{
    public class USATax : ITaxStrategy
    {
        public decimal Calculate(decimal amount) => amount * 0.10m;
    }
}