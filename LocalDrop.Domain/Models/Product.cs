namespace LocalDrop.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int BrandId { get; set; } // FK to Brand
        public Brand Brand { get; set; } = null!; // Navigation property to the Brand

        public int CategoryId { get; set; } // FK to Category
        public Category Category { get; set; } = null!; // Navigation property to the Category

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Slug { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        // one Product has many ProductImages and ProductVariants
        public List<ProductImage> ProductImages { get; set; } = new();
        public List<ProductVariant> ProductVariants { get; set; } = new();


    }
}
