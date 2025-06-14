using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Application.Decorators
{
    public class FraudCheckDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _inner;

        public FraudCheckDecorator(IPaymentProcessor inner)
        {
            _inner = inner;
        }

        public void Execute()
        {
            Logger.Instance.Log("Performing fraud check...");
            _inner.Execute();
        }
    }
}