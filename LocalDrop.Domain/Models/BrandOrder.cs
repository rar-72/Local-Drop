using LocalDrop.Domain.Enums;

namespace LocalDrop.Domain.Models
{
    public class BrandOrder
    {

        public int Id { get; set; }
        public int OrderId { get; set; } // FK to Order
        public Order Order { get; set; } = null!; // Navigation property to the Order
        public int BrandId { get; set; } // FK to Brand
        public Brand Brand { get; set; } = null!; // Navigation property to the Brand

        public decimal Subtotal { get; set; } // Total price of the order before tax and shipping
        public decimal CommissionAmount { get; set; } // Total commission amount for the brand
        public decimal BrandEarning { get; set; } // Total earning for the brand after commission

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public BrandOrderStatus Status { get; set; } = BrandOrderStatus.NewOrder; // Default status is NewOrder


        // One BrandOrder has many OrderItems
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
