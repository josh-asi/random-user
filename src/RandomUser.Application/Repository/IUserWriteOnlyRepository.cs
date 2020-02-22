using System.Threading.Tasks;
using RandomUser.Domain.User;

namespace RandomUser.Application.Repository
{
    public interface IUserWriteOnlyRepository
    {
        Task DeleteAsync(int userId);
        Task UpdateAsync(User user);
    }
}