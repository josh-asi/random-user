using System;
using System.Linq;
using RandomUser.Application.Queries;
using Xunit;
using NSubstitute;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using System.Collections.Generic;

namespace RandomUser.Application.Tests
{
    public class QueryTests
    {
        public readonly IUserQuery userQuery;
        public readonly List<User> users;

        public QueryTests()
        {
            userQuery = Substitute.For<IUserQuery>();
            users = GenerateUsers();
        }


        [Fact]
        public async void User_Should_Be_Grabbed_By_Id()
        {
            var id = 1;
            var name = new Name("Mr" ,"John", "Doe");
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


        private List<User> GenerateUsers()
        {
            var users = new List<User>();

            var id = 1;
            var name = new Name("Mr", "John", "Doe");
            var dob = DateTime.Now;
            var phone = new PhoneNumber(1234567);
            var email = new Email("john.doe@email.com");
            var image = new Image("default-image.jpg");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 2;
            name = new Name("Ms", "John", "Donor");
            dob = DateTime.Now;
            phone = new PhoneNumber(1234568);
            email = new Email("john.donor@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 3;
            name = new Name("Mr", "Jane", "Doe");
            dob = DateTime.Now;
            phone = new PhoneNumber(1234569);
            email = new Email("jane.doe@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 4;
            name = new Name("Mr", "Bob", "Dylan");
            dob = DateTime.Now;
            phone = new PhoneNumber(8673957);
            email = new Email("bob.dylan@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 5;
            name = new Name("Mr", "Robert", "Love");
            dob = DateTime.Now;
            phone = new PhoneNumber(7592648);
            email = new Email("robert.love@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 6;
            name = new Name("Ms", "Daffey", "Duck");
            dob = DateTime.Now;
            phone = new PhoneNumber(6392759);
            email = new Email("daffey.duck@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            return users;
        }
    }
}
