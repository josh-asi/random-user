using System;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.User
{
    public sealed class Name
    {
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string FullName { get; private set; }

        public Name(string title, string firstName, string lastName)
        {

            ValidateInputs(title, firstName, lastName);

            Title = title;
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{title}. {firstName} {LastName}";
        }

        public override string ToString()
        {
            return FullName;
        }

        public static implicit operator string(Name name)
        {
            return name.FullName;
        }

        private void ValidateInputs(string title, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                throw new ShouldNotBeEmptyException("The title, first name, and last name must not be empty");
        }

    }
}
