using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Services
{
    public class BoletoPayment : IPaymentService
    {
        public void ProcessPayment() => Logger.Instance.Log("Processing Boleto payment...");
    }
}