using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using RandomUser.Domain.User.ValueObjects.Exceptions;
using Xunit;
namespace RandomUser.Domain.Tests
{
    public class EmailTests
    {

        // Email should have @
        [Fact]
        public void Email_Format_Should_Be_Valid()
        {
            var email = "email.com";

            Assert.Throws<InvalidFormatException>(() => new Email(email));

        }

        [Fact]
        public void Email_Should_Not_Be_Empty()
        {
            Assert.Throws<ShouldNotBeEmptyException>(() => new Email(""));
        }
    }
}
