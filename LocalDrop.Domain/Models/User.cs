using LocalDrop.Domain.Enums;

namespace LocalDrop.Domain.Models

{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Phone { get; set; }
        public string? Image { get; set; }

        public UserRole Role { get; set; } = UserRole.Customer;
        public bool IsActive { get; set; } = true;
        public bool EmailConfirmed { get; set; }
        public DateTime? LastLoginAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // One user has many addresses and many orders
        public List<Address> Address { get; set; } = new();
        public List<Order> Order { get; set; } = new();

        // One-to-one (optional): a user may have one cart and one brand
        public Cart? Cart { get; set; }
        public Brand? Brand { get; set; }


    }
}
