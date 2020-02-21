using System;
using System.Threading.Tasks;
using RandomUser.Application.Queries;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

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

            Name name = new Name(user.Title, user.FirstName, user.LastName);
            DateTime dob = user.DOB;
            PhoneNumber number = new PhoneNumber(1234567);
            Image image = new Image(user.Image);
            Email email = new Email(user.Email);

            return new User(userId, name, dob, number, email, image);
        }
    }
}
