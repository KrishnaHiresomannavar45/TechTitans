using System;

namespace Booking.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        
        // public User? User { get; set; }  // Keep this commented
        
        public int RoomId { get; set; }
        public Room? Room { get; set; }

        private DateTime _checkInDate;
        public DateTime CheckInDate
        {
            get => _checkInDate;
            set
            {
                if (value.Date < DateTime.Today)
                    throw new ArgumentException("Check-in cannot be in the past");
                _checkInDate = value;
            }
        }

        private DateTime _checkOutDate;
        public DateTime CheckOutDate
        {
            get => _checkOutDate;
            set
            {
                if (value <= CheckInDate)
                    throw new ArgumentException("Check-out must be after check-in");
                _checkOutDate = value;
            }
        }

        private int _guests;
        public int Guests
        {
            get => _guests;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Guests must be at least 1");
                _guests = value;
            }
        }

        public decimal TotalAmount { get; set; }
        public string BookingStatus { get; set; } = "Pending";


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