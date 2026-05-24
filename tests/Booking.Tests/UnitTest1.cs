using Xunit;
using FluentAssertions;

namespace Booking.Tests;

public class HotelBookingTests
{
    [Fact]
    public void Hotel_Room_Should_Have_Valid_Price()
    {
        // This is a placeholder test just to verify xUnit works
        var price = 150;
        price.Should().BeGreaterThan(0);
    }
}