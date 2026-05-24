using Xunit;
using FluentAssertions;
using System;
using global::Booking.Models;

namespace Booking.Tests;

public class PaymentTests
{
    [Fact]
    public void Payment_Should_Throw_When_Amount_Zero()
    {
        Action act = () => new Payment { Amount = 0 };
        act.Should().Throw<ArgumentException>().WithMessage("Amount must be greater than 0");
    }

    [Fact]
    public void Payment_Should_Throw_When_Amount_Negative()
    {
        Action act = () => new Payment { Amount = -100 };
        act.Should().Throw<ArgumentException>().WithMessage("Amount must be greater than 0");
    }

    [Fact]
    public void Payment_Should_Create_With_Valid_Data()
    {
        var payment = new Payment 
        { 
            BookingId = 1,
            Amount = 5000,
            PaymentMethod = "UPI",
            Status = "Success",
            TransactionId = "TXN123456"
        };
        payment.Amount.Should().Be(5000);
        payment.Status.Should().Be("Success");
    }
}