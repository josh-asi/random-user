using RandomUser.Domain.User.ValueObjects;
using RandomUser.Domain.User.ValueObjects.Exceptions;
using Xunit;

namespace RandomUser.Domain.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Phone_Number_Should_Be_7_Digits()
        {
            int number = 1234567;

            PhoneNumber pn = new PhoneNumber(number);

            Assert.Equal(number, pn);

            Assert.Throws<PhoneNumberShouldBe7DigitsException>(() => new PhoneNumber(12345));
            Assert.Throws<PhoneNumberShouldBe7DigitsException>(() => new PhoneNumber(12345678));
        }

        [Fact]
        public void Phone_Number_Should_Not_Be_Negative()
        {
            int number = -21;

            Assert.Throws<InvalidFormatException>(() => new PhoneNumber(number));
            
        }
    }
}
