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

            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void Name_Should_Not_Be_Empty()
        {
            Assert.Throws<ShouldNotBeEmptyException>(() => new Name("", "John", "Doe"));
            Assert.Throws<ShouldNotBeEmptyException>(() => new Name("", "John", ""));
            Assert.Throws<ShouldNotBeEmptyException>(() => new Name("", "", "Doe"));
            Assert.Throws<ShouldNotBeEmptyException>(() => new Name("", "", ""));

        }

    }
}
