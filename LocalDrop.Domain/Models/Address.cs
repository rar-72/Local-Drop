namespace LocalDrop.Domain.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int UserId { get; set; } // Foreign key to the Users table

        public User user { get; set; } = null!;// Navigation property to the Users table 

        [Required, StringLength(100)]
        public string? ReceiverName { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string? ReceiverPhone { get; set; }
        [Required, StringLength(100)]
        public string? Governorate { get; set; }
        [Required, StringLength(100)]
        public string? City { get; set; }

        public string? Street { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // One address can have many orders
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
