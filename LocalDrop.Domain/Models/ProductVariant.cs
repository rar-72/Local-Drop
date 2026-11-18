using System.Data;

namespace LocalDrop.Domain.Models
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int StockQuantity { get; set; } // The quantity of this variant in stock
        public int ProductId { get; set; } // FK to Product
        public Product Product { get; set; } = null!; // Navigation property to the Product

        public string? VariantName { get; set; } //  "Size", "Color"
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        public string SKU { get; set; } = string.Empty; // Stock Keeping Unit , The Brand Using this to track inventory
        public DataRowVersion RowVersion { get; set; } = new(); // For optimistic concurrency control
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;



    }
}
