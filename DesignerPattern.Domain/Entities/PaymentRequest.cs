
namespace DesignerPattern.Domain.Entities
{
    // Representa uma solicita��o de pagamento
    public class PaymentRequest
    {
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}