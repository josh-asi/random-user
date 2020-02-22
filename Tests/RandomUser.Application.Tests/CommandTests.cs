using System;
using System.Linq;
using RandomUser.Application.Queries;
using Xunit;
using NSubstitute;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using System.Collections.Generic;
using RandomUser.Application.Repository;
using RandomUser.Application.Commands.UpdateUser;

namespace RandomUser.Application.Tests
{
    public class CommandTests
    {
        public readonly IUserWriteOnlyRepository userWriteOnlyRepository;
        public readonly IUserReadOnlyRepository userReadOnlyRepository;

        public readonly List<User> users;

        public CommandTests()
        {
            userWriteOnlyRepository = Substitute.For<IUserWriteOnlyRepository>();
            userReadOnlyRepository = Substitute.For<IUserReadOnlyRepository>();
            users = UserGeneration.Generate();
        }

        [Fact]
        public async void Update_Name()
        {
            var userId = 1;
            var newName = new Name(Title.MS, "Jane", "Doe");

            userReadOnlyRepository.Get(userId).Returns(users[0]);

            var updateNameUseCase = new UpdateUserUseCase(userWriteOnlyRepository, userReadOnlyRepository);

            var result = await updateNameUseCase.Execute(userId, newName);

            Assert.Equal(newName.FullName, result.Name.FullName);
        }
    }
}
