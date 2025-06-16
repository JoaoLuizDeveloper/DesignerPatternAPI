using DesignerPattern.Application.Interfaces;
using DesignerPattern.Application.Services;

namespace DesignerPattern.Application.Factories
{
    // Implements the Factory pattern to create instances of payment services
    // Allows us to create objects without specifying the exact class of the object being created
    public class PaymentFactory
    {
        // Creates an instance of IPaymentService based on the provided type
        public static IPaymentService Create(string type)
        {
            // Returns the payment instance according to the type
            return type switch
            {
                "pix" => new PixPayment(),
                "boleto" => new BoletoPayment(),
                _ => throw new ArgumentException("Invalid type")
            };
        }
    }
}