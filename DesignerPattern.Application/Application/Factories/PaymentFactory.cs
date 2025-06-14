using DesignerPattern.Application.Interfaces;
using DesignerPattern.Application.Services;

namespace DesignerPattern.Application.Factories
{
    public class PaymentFactory
    {
        public static IPaymentService Create(string type)
        {
            return type switch
            {
                "pix" => new PixPayment(),
                "boleto" => new BoletoPayment(),
                _ => throw new ArgumentException("Invalid type")
            };
        }
    }
}