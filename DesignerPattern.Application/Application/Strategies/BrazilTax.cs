namespace DesignerPattern.Application.Strategies
{
    public class BrazilTax : ITaxStrategy
    {
        // Realiza o do cálculo do imposto para o Brasil
        public decimal Calculate(decimal amount) => amount * 0.15m;
    }
}
