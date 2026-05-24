using System;

namespace Booking.Models
{
    public class User
    {
        public int Id { get; set; }
        
        private string _email = string.Empty;
        public string Email 
        { 
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email cannot be empty");
                if (!value.Contains("@"))
                    throw new ArgumentException("Email must contain @");
                _email = value;
            }
        }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
            }
        }
        
        public string Phone { get; set; } = string.Empty;
    }
}