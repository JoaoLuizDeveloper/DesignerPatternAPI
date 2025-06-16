using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Application.Decorators
{
    // Decorator for fraud check in payment processing
    public class FraudCheckDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _inner;

        // Constructor that receives the internal payment processor
        public FraudCheckDecorator(IPaymentProcessor inner)
        {
            _inner = inner;
        }

        // Checks for fraud before processing the payment
        public void Execute()
        {
            Logger.Instance.Log("Performing fraud check...");
            _inner.Execute();
        }
    }
}