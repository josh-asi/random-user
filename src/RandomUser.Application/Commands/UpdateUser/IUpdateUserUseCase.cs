using System.Threading.Tasks;
using RandomUser.Domain.User;

namespace RandomUser.Application.Commands.UpdateUser
{
    public interface IUpdateUserUseCase
    { 
       Task<User> Execute(int userId, Name newName);
    }
}
