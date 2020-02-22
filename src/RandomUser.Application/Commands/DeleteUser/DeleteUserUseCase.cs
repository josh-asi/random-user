using System.Threading.Tasks;
using RandomUser.Application.Repository;


namespace RandomUser.Application.Commands.DeleteUser
{
    public class DeleteUserUseCase : IDeleteUserUseCase
    {
        private readonly IUserWriteOnlyRepository userWriteOnlyRepository;
        private readonly IUserReadOnlyRepository userReadOnlyRepository;

        public DeleteUserUseCase(IUserWriteOnlyRepository userWriteOnlyRepository, IUserReadOnlyRepository userReadOnlyRepository)
        {
            this.userWriteOnlyRepository = userWriteOnlyRepository;
            this.userReadOnlyRepository = userReadOnlyRepository;
        }

        public async Task Execute(int userId)
        {
            var user = await userReadOnlyRepository.Get(userId);
            if (user == null) throw new NotFoundException("User not found");
            await userWriteOnlyRepository.Delete(userId);
        }
    }
}
