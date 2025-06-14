
namespace DesignerPattern.Domain.Entities
{
    public class PaymentRequest
    {
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}