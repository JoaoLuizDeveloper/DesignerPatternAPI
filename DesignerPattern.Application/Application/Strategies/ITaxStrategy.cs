namespace DesignerPattern.Application.Strategies
{
    public interface ITaxStrategy
    {
        // Interface for tax calculation
        decimal Calculate(decimal amount);
    }
}