namespace Booking.Models
{
    public class Room
    {
        public int Id { get; set; }


        private string _roomNumber = string.Empty;
        public string RoomNumber
        {
            get => _roomNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("RoomNumber cannot be null or empty");
                _roomNumber = value;
            }
        }

        private string _roomType = string.Empty;
        public string RoomType
        {
            get => _roomType;
            set => _roomType = value ?? string.Empty;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                _price = value;
            }
        }

        private int _capacity;
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Capacity must be at least 1");
                _capacity = value;
            }
        }

        public bool IsAvailable { get; set; } = true;
        public string Description { get; set; } = string.Empty;

        public string RoomNumber { get; set; } = string.Empty;

        public string RoomType { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Capacity { get; set; }

        public bool IsAvailable { get; set; }

        public string Description { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;
    }
}