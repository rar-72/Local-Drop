using LocalDrop.Domain.Enums;

namespace LocalDrop.Domain.Models
{
    public class Payment
    {

        public int Id { get; set; }
        public int OderId { get; set; } // FK to Order
        public Order Order { get; set; } = null!; // Navigation property to the Order
        public PaymentMethod Method { get; set; } = PaymentMethod.CashonDelivery; // Default payment method is Cash on Delivery
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending; // Default payment status is Pending

        public decimal Amount { get; set; }
        public string TransactionId { get; set; } = string.Empty; // Unique transaction ID for the payment
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
