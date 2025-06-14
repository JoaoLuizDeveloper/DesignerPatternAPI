using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Services
{
    public class PixPayment : IPaymentService
    {
        public void ProcessPayment() => Logger.Instance.Log("Processing Pix payment...");
    }
}
