namespace LocalDrop.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; } // FK to User
        public User User { get; set; } = null!; // Navigation property to the User
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // One cart has many CartItems
        public List<CartItem> CartItems { get; set; } = new();
    }
}
