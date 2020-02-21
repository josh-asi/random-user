using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandomUser.Application.Queries
{
    public interface IUserQuery
    {
        Task<Domain.User.User> GetUserAsync(int userId);
        //Task<List<Domain.User.User>> GetUsersAsync();
        //Task<List<Domain.User.User>> GetUsersAsync(int limit);
        //Task<List<Domain.User.User>> GetUsersByFirstNameAsync(string name);
        //Task<List<Domain.User.User>> GetUsersByLastNameAsync(string name);
    }
}
