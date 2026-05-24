using System;

namespace Booking.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking? Booking { get; set; }
        
        private decimal _amount;
        public decimal Amount 
        { 
            get => _amount;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Amount must be greater than 0");
                _amount = value;
            }
        }
        
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; } = string.Empty; // "Card", "UPI", "Cash"
        public string Status { get; set; } = "Pending"; // "Pending", "Success", "Failed"
        public string TransactionId { get; set; } = string.Empty;


        public int BookingId { get; set; }

        public Booking? Booking { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string PaymentStatus { get; set; } = "Pending";

        public string TransactionId { get; set; } = string.Empty;

        public DateTime PaidAt { get; set; } = DateTime.UtcNow;

    }
}