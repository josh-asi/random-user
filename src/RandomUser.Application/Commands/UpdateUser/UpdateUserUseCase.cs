using RandomUser.Application.Repository;
using RandomUser.Domain.User;
using System.Threading.Tasks;

namespace RandomUser.Application.Commands.UpdateUser
{
    public class UpdateUserUseCase : IUpdateUserUseCase
    {
        private readonly IUserWriteOnlyRepository userWriteOnlyRepository;
        private readonly IUserReadOnlyRepository userReadOnlyRepository;

        public UpdateUserUseCase(IUserWriteOnlyRepository userWriteOnlyRepository, IUserReadOnlyRepository userReadOnlyRepository)
        {
            this.userWriteOnlyRepository = userWriteOnlyRepository;
            this.userReadOnlyRepository = userReadOnlyRepository;
        }

        public async Task<User> Execute(int userId, Name newName)
        {
            var user = await userReadOnlyRepository.Get(userId);
            if (user == null) throw new NotFoundException("User not found");

            user.UpdateName(newName);

            await userWriteOnlyRepository.UpdateAsync(user);

            return user;
        }
    }
}
