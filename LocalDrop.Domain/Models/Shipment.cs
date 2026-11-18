
using LocalDrop.Domain.Enums;
namespace LocalDrop.Domain.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public int BrandOrderId { get; set; } // FK to BrandOrder
        public BrandOrder BrandOrder { get; set; } = null!; // Navigation property to the BrandOrder

        public string TrackingNumber { get; set; } = string.Empty;
        public string ShippingCompany { get; set; } = string.Empty;
        public DateTime? DeliveredAt { get; set; } // Nullable, as the shipment may not be delivered yet

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        // Default status is Preparing
        public ShipmentStatus status { get; set; } = ShipmentStatus.Preparing;

    }
}
