using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using RandomUser.Application.Queries;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;
using Microsoft.EntityFrameworkCore;
using RandomUser.Application;

namespace RandomUser.Infrastructure.EntityFramework.Queries
{
    public class UserQuery : IUserQuery
    {
        private readonly Context context;

        public UserQuery(Context context)
        {
            this.context = context;
        }

        public async Task<User> GetUserAsync(int userId)
        {
            Entities.User user = await context.Users.FindAsync(userId);

            if (user == null) throw new NotFoundException("User not found");

            Name name = new Name(user.Title, user.FirstName, user.LastName);
            DateTime dob = user.DOB;
            PhoneNumber number = new PhoneNumber(user.PhoneNumber);
            Image image = new Image(user.Image);
            Email email = new Email(user.Email);

            return new User(userId, name, dob, number, email, image);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var dbUsers = await context.Users.ToListAsync();
            if (dbUsers == null) throw new NotFoundException("Cannot find any users in DB");

            return mapUsers(dbUsers);
        }

        public async Task<List<User>> GetUsersAsync(int limit)
        {
            var dbUsers = await context.Users.Take(limit).ToListAsync();
            if (limit > 0 && dbUsers == null) throw new NotFoundException("Cannot find any users in DB");

            return mapUsers(dbUsers);
        }

        public async Task<List<User>> GetUsersByFirstNameAsync(string name)
        {
            var dbUsers = await context.Users.Where(u => u.FirstName.ToLower() == name.ToLower()).ToListAsync();
            if (dbUsers.Count == 0) throw new NotFoundException($"Cannot find any users with a first name of {name}");

            return mapUsers(dbUsers);
        }

        public async Task<List<User>> GetUsersByLastNameAsync(string name)
        {
            var dbUsers = await context.Users.Where(u => u.LastName.ToLower() == name.ToLower()).ToListAsync();
            if (dbUsers.Count == 0) throw new NotFoundException($"Cannot find any users with a last name of {name}");

            return mapUsers(dbUsers);
        }


        private List<User> mapUsers(List<Entities.User> dbUsers)
        {
            var users = new List<User>();
                       
            foreach(Entities.User user in dbUsers)
            {
                users.Add(new User(
                    user.Id,
                    new Name(user.Title, user.FirstName, user.LastName),
                    user.DOB,
                    new PhoneNumber(user.PhoneNumber),
                    new Email(user.Email),
                    new Image(user.Image))
                    );
            }
            
            return users;
        }

    }
}
