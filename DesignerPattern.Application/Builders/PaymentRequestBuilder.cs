using DesignerPattern.Domain.Entities;

namespace DesignerPattern.Application.Builders
{
    public class PaymentRequestBuilder
    {
        private readonly PaymentRequest _request = new();

        public PaymentRequestBuilder WithMethod(string method)
        {
            _request.Method = method;
            return this;
        }

        public PaymentRequestBuilder WithAmount(decimal amount)
        {
            _request.Amount = amount;
            return this;
        }

        public PaymentRequestBuilder WithDescription(string description)
        {
            _request.Description = description;
            return this;
        }

        public PaymentRequest Build() => _request;
    }
}
