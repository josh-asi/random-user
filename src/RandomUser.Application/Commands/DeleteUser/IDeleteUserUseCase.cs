using System.Threading.Tasks;

namespace RandomUser.Application.Commands.DeleteUser
{
    public interface IDeleteUserUseCase
    {
        Task Execute(int userId);
    }
}