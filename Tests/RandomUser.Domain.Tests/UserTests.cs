using System;
using Xunit;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.Tests
{
    public class UserTests
    {
        [Fact]
        public void User_Details_Should_Not_Be_Empty()
        {
            var name = new Name(Title.MR, "John", "Doe");
            var dob = DateTime.Now;
            var phoneNo = new PhoneNumber(1234567);
            var image = new Image("some-image");

            var user = new User.User(name, dob, phoneNo, image);

            Assert.NotNull(user);
           
        }
    }
}
