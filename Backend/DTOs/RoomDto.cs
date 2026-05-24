namespace Booking.DTOs
{
    public class RoomDto
    {
        public string RoomNumber { get; set; } = string.Empty;

        public string RoomType { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}