namespace Booking.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public Booking? Booking { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string PaymentStatus { get; set; } = "Pending";

        public string TransactionId { get; set; } = string.Empty;

        public DateTime PaidAt { get; set; } = DateTime.UtcNow;
    }
}