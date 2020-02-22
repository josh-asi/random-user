using RandomUser.Domain.User;
using Xunit;
namespace RandomUser.Domain.Tests
{
    public class ImageTests
    {
       [Fact]
       public void Image_Should_Have_A_Default_And_Thumbnail()
        {

            string defaultLink = "testing";
            string thumbnail = $"{defaultLink}--small";

            Image image = new Image(defaultLink);

            Assert.Equal(image.DefaultLink, defaultLink);
            Assert.Equal(image.Thumbnail, thumbnail);
            
        }

        [Fact]
        public void Image_Link_Should_Not_Be_Empty()
        {
            Assert.Throws<ShouldNotBeEmptyException>(() => new Image(""));
        }
    }
}
