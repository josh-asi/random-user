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

        public async Task<User> GetUserAsync(Guid userId)
        {
            Entities.User user = await context.Users.FindAsync(userId);

            Name name = new Name(user.Title, user.FirstName, user.LastName);
            DateTime dob = user.DOB;
            PhoneNumber number = new PhoneNumber(user.PhoneNumber);
            Image image = new Image(user.Image);

            return new User(name, dob, number, image);
        }
    }
}
