namespace DesignerPattern.Application.Strategies
{
    public interface ITaxStrategy
    {
        // Interface para o cálculo de imposto
        decimal Calculate(decimal amount);
    }
}