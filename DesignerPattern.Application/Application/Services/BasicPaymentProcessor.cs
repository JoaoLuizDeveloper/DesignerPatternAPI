using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Services
{
    public class BasicPaymentProcessor : IPaymentProcessor
    {
        public void Execute() => Logger.Instance.Log("Executing basic payment...");
    }
}
