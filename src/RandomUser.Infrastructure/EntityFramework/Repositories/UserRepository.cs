﻿using System;
using System.Threading.Tasks;
using RandomUser.Application.Repository;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Infrastructure.EntityFramework.Repositories
{
    public class UserRepository : IUserWriteOnlyRepository, IUserReadOnlyRepository 
    {
        private Context context;

        public UserRepository(Context context)
        {
            this.context = context;
        }

        public async Task<User> Get(int userId)
        {
            Entities.User user = await context.Users.FindAsync(userId);
            Name name = new Name(user.Title, user.FirstName, user.LastName);
            DateTime dob = user.DOB;
            PhoneNumber number = new PhoneNumber(user.PhoneNumber);
            Image image = new Image(user.Image);
            Email email = new Email(user.Email);

            return new User(userId, name, dob, number, email, image);
        }

        public async Task Delete(int userId)
        {
            Entities.User user = await context.Users.FindAsync(userId);
            context.Remove(user);
            await context.SaveChangesAsync();
        }
    }
}
