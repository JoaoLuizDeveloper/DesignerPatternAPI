using DesignerPattern.Domain.Entities;

namespace DesignerPattern.Application.Builders
{
    // Implementando o padrão Builder para criar uma solicitação de pagamento
    public class PaymentRequestBuilder
    {
        private readonly PaymentRequest _request = new();

        // Define o metodo para pagamento pagamento
        public PaymentRequestBuilder WithMethod(string method)
        {
            _request.Method = method;
            return this;
        }

        // Define o valor do pagamento
        public PaymentRequestBuilder WithAmount(decimal amount)
        {
            _request.Amount = amount;
            return this;
        }

        // Define a descrição do pagamento
        public PaymentRequestBuilder WithDescription(string description)
        {
            _request.Description = description;
            return this;
        }

        public PaymentRequest Build() => _request;
    }
}