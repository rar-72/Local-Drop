namespace LocalDrop.Domain.Models
{
    public class CartItem
    {

        public int Id { get; set; }
        public int CartId { get; set; } // FK to Cart
        public Cart Cart { get; set; } = null!; // Navigation property to the Cart
        public int ProductVariantId { get; set; } // FK to ProductVariant
        public ProductVariant ProductVariant { get; set; } = null!; // Navigation property to the ProductVariant


        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
