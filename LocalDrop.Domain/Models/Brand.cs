namespace LocalDrop.Domain.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public int OwnerUserId { get; set; }
        public User Owner { get; set; } = null!;

        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string Email { get; set; } = string.Empty;
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;
        public string? Logo { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

        public string? PaymentAccount { get; set; } = string.Empty;

        public decimal CommissionRate { get; set; } = 0.0m; // Commission rate as a percentage (e.g., 0.05 for 5%)
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // One brand has many products and many orders
        public List<Product> Products { get; set; } = new();
        public List<BrandOrder> BrandOrders { get; set; } = new();


    }
}
