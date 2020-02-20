using System;
namespace RandomUser.Domain.User
{
    public sealed class Name
    {
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name()
        {
        }
    }
}
