using System;
using Xunit;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using RandomUser.Domain.User.ValueObjects.Exceptions;

namespace RandomUser.Domain.Tests
{
    public class UserTests
    {
        [Fact]
        public void User_Details_Should_Not_Be_Empty()
        {
            var id = 1;
            var name = new Name(Title.MR, "John", "Doe");
            var dob = DateTime.Now;
            var phoneNo = new PhoneNumber(1234567);
            var image = new Image("some-image");
            var email = new Email("john.doe@email.com");

            var user = new User.User(id, name, dob, phoneNo, email, image);

            Assert.NotNull(user);
           
        }

        [Fact]
        public void User_Id_Should_Not_Be_Negative()
        {
            var id = -1;
            var name = new Name(Title.MR, "John", "Doe");
            var dob = DateTime.Now;
            var phoneNo = new PhoneNumber(1234567);
            var image = new Image("some-image");
            var email = new Email("john.doe@email.com");

            Assert.Throws<InvalidFormatException>(() => new User.User(id, name, dob, phoneNo, email, image));
        }
    }
}
