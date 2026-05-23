namespace Booking.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public int RoomId { get; set; }

        public Room? Room { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int Guests { get; set; }

        public decimal TotalAmount { get; set; }

        public string BookingStatus { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}