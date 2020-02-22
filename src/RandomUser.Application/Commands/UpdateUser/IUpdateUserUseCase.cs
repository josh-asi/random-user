using RandomUser.Domain.User;
using System.Threading.Tasks;

namespace RandomUser.Application.Commands.UpdateUser
{
    public interface IUpdateUserUseCase
    {
        Task<User> Execute(int userId, Name newName);
    }
}
