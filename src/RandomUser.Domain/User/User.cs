using System;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.User
{
    public sealed class User
    {
        public Guid Id { get; private set; }
        public Name Name {get; private set;}
        public DateTime DOB { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public Image Image { get; private set; }

        public User()
        {
        }
    }
}
