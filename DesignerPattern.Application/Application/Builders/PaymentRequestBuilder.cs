using DesignerPattern.Domain.Entities;

namespace DesignerPattern.Application.Builders
{
    // Implementing the Builder pattern to create a payment request
    public class PaymentRequestBuilder
    {
        private readonly PaymentRequest _request = new();

        // Sets the payment method
        public PaymentRequestBuilder WithMethod(string method)
        {
            _request.Method = method;
            return this;
        }

        // Sets the payment amount
        public PaymentRequestBuilder WithAmount(decimal amount)
        {
            _request.Amount = amount;
            return this;
        }

        // Sets the payment description
        public PaymentRequestBuilder WithDescription(string description)
        {
            _request.Description = description;
            return this;
        }

        public PaymentRequest Build() => _request;
    }
}