namespace DesignerPattern.Application.Strategies
{
    public class USATax : ITaxStrategy
    {
        // Performs tax calculation for the United States
        public decimal Calculate(decimal amount) => amount * 0.10m;
    }
}