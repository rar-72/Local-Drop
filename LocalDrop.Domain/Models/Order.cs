using LocalDrop.Domain.Enums;

namespace LocalDrop.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } // FK to User
        public User User { get; set; } = null!; // Navigation property to the User
        public int AddressId { get; set; } // FK to Address
        public Address Address { get; set; } = null!; // Navigation property to the Address
        public OrderStatus Status { get; set; } = OrderStatus.NewOrder; // Default status is NewOrder

        public string OrderNumber { get; set; } = string.Empty; // Unique order number
        public string ShippingName { get; set; } = string.Empty;
        public string ShippingPhone { get; set; } = string.Empty;

        public string ShippingGovernorate { get; set; } = string.Empty;
        public string ShippingCity { get; set; } = string.Empty;
        public string ShippingStreet { get; set; } = string.Empty;


        public decimal Subtotal { get; set; } // Total price of the order before tax and shipping
        public decimal ShippingTotal { get; set; } // Total shipping cost
        public decimal Discount { get; set; } // Total discount applied to the order
        public decimal TotalAmount { get; set; } // Total amount paid by the user


        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        // One order has many BrandOrders and Payments and OrderItems
        public List<BrandOrder> BrandOrders { get; set; } = new();
        public List<Payment> Payments { get; set; } = new();
        public List<OrderItem> OrderItems { get; set; } = new();


    }
}
