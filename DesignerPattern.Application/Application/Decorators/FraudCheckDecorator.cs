using DesignerPattern.Application.Interfaces;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Application.Application.Decorators
{
    // Decorator para verificação de fraude no processamento de pagamento
    public class FraudCheckDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _inner;

        // Construtor que recebe o processador de pagamento interno
        public FraudCheckDecorator(IPaymentProcessor inner)
        {
            _inner = inner;
        }

        // Verifica se existe fraude antes de processar o pagamento
        public void Execute()
        {
            Logger.Instance.Log("Performing fraud check...");
            _inner.Execute();
        }
    }
}