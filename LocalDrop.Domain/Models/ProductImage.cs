namespace LocalDrop.Domain.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // FK to Product
        public Product Product { get; set; } = null!; // Navigation property to the Product

        public string ImageUrl { get; set; } = string.Empty;
        public bool IsMain { get; set; } = false; //  True for the first picture shown in the product list
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
