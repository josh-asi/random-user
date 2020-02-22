using System.Threading.Tasks;
using RandomUser.Domain.User;

namespace RandomUser.Application.Repository
{
    public interface IUserReadOnlyRepository
    {
        Task<User> Get(int userId);
    }
}
