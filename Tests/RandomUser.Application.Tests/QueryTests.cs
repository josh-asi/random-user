using NSubstitute;
using RandomUser.Application.Queries;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RandomUser.Application.Tests
{
    public class QueryTests
    {
        public readonly IUserQuery userQuery;
        public readonly List<User> users;

        public QueryTests()
        {
            userQuery = Substitute.For<IUserQuery>();
            users = UserGeneration.Generate();
        }


        [Fact]
        public async void User_Should_Be_Grabbed_By_Id()
        {
            var id = 1;
            var name = new Name("Mr", "John", "Doe");
            var dob = DateTime.Now;
            var phone = new PhoneNumber(1234567);
            var email = new Email("john.doe@email.com");
            var image = new Image("default-image");

            var user = new User(id, name, dob, phone, email, image);

            userQuery.GetUserAsync(user.Id).Returns(user);

            var result = await userQuery.GetUserAsync(user.Id);

            Assert.NotNull(result);
            Assert.Equal(id, user.Id);
        }

        [Fact]
        public async void Users_Should_Be_Returned()
        {
            userQuery.GetUsersAsync().Returns(users);

            var userList = await userQuery.GetUsersAsync();

            Assert.Equal(users, userList);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(6)]
        public async void Users_Should_Be_Limited_By_A_Number(int limit)
        {
            var limitedUsers = users.Take(limit).ToList();

            userQuery.GetUsersAsync(limit).Returns(limitedUsers);

            var result = await userQuery.GetUsersAsync(limit);

            Assert.Equal(limitedUsers.Count, result.Count);
            Assert.Equal(limitedUsers, result);
        }


        [Theory]
        [InlineData("John")]
        [InlineData("Jane")]
        public async void Users_Should_Be_Filtered_By_First_Name(string firstName)
        {
            var filteredUsers = users.Where(user => user.Name.FirstName == firstName).ToList();

            userQuery.GetUsersByFirstNameAsync(firstName).Returns(filteredUsers);

            var result = await userQuery.GetUsersByFirstNameAsync(firstName);

            Assert.Equal(filteredUsers, result);
            Assert.Equal(filteredUsers[0].Name.FirstName, result[0].Name.FirstName);
        }

        [Theory]
        [InlineData("Doe")]
        [InlineData("Dylan")]
        public async void Users_Should_Be_Filtered_By_Last_Name(string lastName)
        {
            var filteredUsers = users.Where(user => user.Name.LastName == lastName).ToList();

            userQuery.GetUsersByLastNameAsync(lastName).Returns(filteredUsers);

            var result = await userQuery.GetUsersByLastNameAsync(lastName);

            Assert.Equal(filteredUsers, result);
            Assert.Equal(filteredUsers[0].Name.LastName, result[0].Name.LastName);
        }
    }
}
