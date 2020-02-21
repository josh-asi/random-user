using System;
using RandomUser.Application.Queries;
using Xunit;
using NSubstitute;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Application.Tests
{
    public class QueryTests
    {
        public readonly IUserQuery userQuery;

        public QueryTests()
        {
            userQuery = Substitute.For<IUserQuery>();
        }


        [Fact]
        public async void User_Should_Be_Grabbed_By_id()
        {
            var id = 1;
            var name = new Name("Mr" ,"John", "Doe");
            var dob = DateTime.Now;
            var phone = new PhoneNumber(1234567);
            var image = new Image("default-image");

            var user = new User(id, name, dob, phone, image);

            userQuery.GetUserAsync(user.Id).Returns(user);

            var result = await userQuery.GetUserAsync(user.Id);

            Assert.NotNull(result);
            Assert.Equal(id, user.Id);
        }
    }
}
