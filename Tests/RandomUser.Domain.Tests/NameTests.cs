using Xunit;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.Tests
{
    public class NameTests
    {
        [Fact]
        public void Name_Should_Have_Correct_Title()
        {
            Name name = new Name(Title.MR, "John", "Doe");

            string expectedName = "Mr. John Doe";

            Assert.Equal(expectedName, name.ToString());
        }

    }
}
