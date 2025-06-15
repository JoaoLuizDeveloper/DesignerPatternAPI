
namespace DesignerPattern.Domain.Entities
{
    // Representa uma solicitação de pagamento
    public class PaymentRequest
    {
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}