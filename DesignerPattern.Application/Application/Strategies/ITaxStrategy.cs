namespace DesignerPattern.Application.Strategies
{
    public interface ITaxStrategy
    {
        decimal Calculate(decimal amount);
    }
}