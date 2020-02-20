using System;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.User
{
    public sealed class Name
    {
        public Title Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string FullName { get; private set; }

        public Name(Title title, string firstName, string lastName)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;

            string prefix = title == Title.MR ? "Mr" : "Ms";

            FullName = $"{prefix}. {firstName} {LastName}";
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
