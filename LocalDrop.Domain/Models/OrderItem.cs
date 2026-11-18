namespace LocalDrop.Domain.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int BrandOrderId { get; set; } // FK to BrandOrder
        public BrandOrder BrandOrder { get; set; } = null!; // Navigation property to the BrandOrder
        public int ProductVariantId { get; set; } // FK to ProductVariant
        public ProductVariant ProductVariant { get; set; } = null!; // Navigation property to the ProductVariant


        public string ProductName { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // The price of one piece at purchase time.



        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}

