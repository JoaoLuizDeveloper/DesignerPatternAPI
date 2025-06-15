namespace DesignerPattern.Application.Strategies
{
    public class USATax : ITaxStrategy
    {
        //Realiza o cálculo do imposto para os Estados Unidos
        public decimal Calculate(decimal amount) => amount * 0.10m;
    }
}