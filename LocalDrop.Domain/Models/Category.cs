namespace LocalDrop.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }

        // FK to the same table. null means this is a main category
        public int? ParentCategoryId { get; set; }

        // The category above this one (its parent)
        public Category? ParentCategory { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;



        public List<Category> SubCategories { get; set; } = new();

        // One category has many products
        public List<Product> Products { get; set; } = new();
    }
}
