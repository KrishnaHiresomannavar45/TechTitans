using Xunit;
using FluentAssertions;
using global::Booking.Models;

namespace Booking.Tests;

public class RoomTests
{
  [Fact]
   public void Room_Price_Should_Not_Be_Negative()
    {
        var room = new Room { Price = 100 };
        room.Price.Should().BeGreaterThanOrEqualTo(0);
    }
[Fact]
    
    public void Room_Capacity_Should_Be_At_Least_One()
    {
        var room = new Room { Capacity = 2 };
        room.Capacity.Should().BeGreaterThan(0);
    }

    [Fact]
    public void Room_RoomNumber_Should_Not_Be_Empty()
    {
        var room = new Room { RoomNumber = "101" };
        room.RoomNumber.Should().NotBeNullOrEmpty();
    }
    [Fact]
    
public void Room_Should_Throw_When_Price_Is_Negative()
{
    Action act = () => new Room { Price = -100 };
    act.Should().Throw<ArgumentException>();
}
}