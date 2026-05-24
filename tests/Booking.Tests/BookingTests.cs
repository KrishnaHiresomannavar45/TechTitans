using Xunit;
using FluentAssertions;
using System;
using global::Booking.Models;

namespace Booking.Tests;

public class BookingTests
{
    [Fact]
    public void Booking_Should_Throw_When_CheckIn_In_Past()
    {
        var room = new Room { Price = 100, Capacity = 2, RoomNumber = "101" };
        
        Action act = () => new global::Booking.Models.Booking  // ← changed here
        { 
            Room = room,
            Guests = 1,
            CheckInDate = DateTime.Today.AddDays(-1), 
            CheckOutDate = DateTime.Today.AddDays(1) 
        };

        act.Should().Throw<ArgumentException>()
           .WithMessage("Check-in cannot be in the past");
    }

    [Fact]
    public void Booking_Should_Throw_When_CheckOut_Before_CheckIn()
    {
        var room = new Room { Price = 100, Capacity = 2, RoomNumber = "101" };
        
        Action act = () => new global::Booking.Models.Booking  // ← changed here
        { 
            Room = room,
            Guests = 1,
            CheckInDate = DateTime.Today.AddDays(2),
            CheckOutDate = DateTime.Today.AddDays(1)
        };

        act.Should().Throw<ArgumentException>()
           .WithMessage("Check-out must be after check-in");
    }

    [Fact]
    public void Booking_Should_Throw_When_Guests_Less_Than_One()
    {
        var room = new Room { Price = 100, Capacity = 2, RoomNumber = "101" };
        
        Action act = () => new global::Booking.Models.Booking  // ← changed here
        { 
            Room = room,
            Guests = 0,
            CheckInDate = DateTime.Today.AddDays(1),
            CheckOutDate = DateTime.Today.AddDays(2)
        };

        act.Should().Throw<ArgumentException>()
           .WithMessage("Guests must be at least 1");
    }

    [Fact]
    public void Booking_Should_Create_With_Valid_Data()
    {
        var room = new Room { Price = 100, Capacity = 2, RoomNumber = "101" };
        
        var booking = new global::Booking.Models.Booking  // ← changed here
        {
            Room = room,
            Guests = 2,
            CheckInDate = DateTime.Today.AddDays(1),
            CheckOutDate = DateTime.Today.AddDays(3),
            TotalAmount = 200,
            BookingStatus = "Confirmed"
        };

        booking.CheckOutDate.Should().BeAfter(booking.CheckInDate);
        booking.Guests.Should().Be(2);
        booking.BookingStatus.Should().Be("Confirmed");
    }
}