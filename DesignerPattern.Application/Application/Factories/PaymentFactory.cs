using DesignerPattern.Application.Interfaces;
using DesignerPattern.Application.Services;

namespace DesignerPattern.Application.Factories
{
    // Implementa o padrão Factory para criar instâncias de serviços de pagamento
    // Podemos criar objetos sem especificar a classe exata do objeto que será criado.
    public class PaymentFactory
    {
        // Cria uma instância de IPaymentService com base no tipo fornecido
        public static IPaymentService Create(string type)
        {
            // Traz as instâncias de pagamento de acordo com o tipo
            return type switch
            {
                "pix" => new PixPayment(),
                "boleto" => new BoletoPayment(),
                _ => throw new ArgumentException("Invalid type")
            };
        }
    }
}