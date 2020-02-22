using System.Threading.Tasks;

namespace RandomUser.Application.Repository
{
    public interface IUserWriteOnlyRepository
    {
        Task Delete(int userId);
    }
}
