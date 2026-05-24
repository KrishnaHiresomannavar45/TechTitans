using Xunit;
using FluentAssertions;
using System;
using global::Booking.Models;

namespace Booking.Tests;

public class UserTests
{
    [Fact]
    public void User_Should_Throw_When_Email_Empty()
    {
        Action act = () => new global::Booking.Models.User { Email = "", Name = "Aishwarya" };
        act.Should().Throw<ArgumentException>().WithMessage("Email cannot be empty");
    }

    [Fact]
    public void User_Should_Throw_When_Email_Invalid()
    {
        Action act = () => new global::Booking.Models.User { Email = "notanemail", Name = "Aishwarya" };
        act.Should().Throw<ArgumentException>().WithMessage("Email must contain @");
    }

    [Fact]
    public void User_Should_Throw_When_Name_Empty()
    {
        Action act = () => new global::Booking.Models.User { Email = "test@test.com", Name = "" };
        act.Should().Throw<ArgumentException>().WithMessage("Name cannot be empty");
    }

    [Fact]
    public void User_Should_Create_With_Valid_Data()
    {
        var user = new global::Booking.Models.User 
        { 
            Email = "aishwarya@test.com", 
            Name = "Aishwarya",
            Phone = "9876543210"
        };
        user.Email.Should().Be("aishwarya@test.com");
        user.Name.Should().Be("Aishwarya");
    }
}
