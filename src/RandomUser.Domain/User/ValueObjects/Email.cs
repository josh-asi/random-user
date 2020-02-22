using System;
using RandomUser.Domain.User.ValueObjects.Exceptions;

namespace RandomUser.Domain.User.ValueObjects
{
    public sealed class Email
    {
        private string EmailAddress;

        public Email(string email)
        {
            if (string.IsNullOrEmpty(email)) throw new ShouldNotBeEmptyException("Email should not be empty");
            if (!email.Contains('@')) throw new InvalidFormatException("Email format invalid");

            EmailAddress = email;
        }

        public override string ToString()
        {
            return EmailAddress;
        }

        public static implicit operator string(Email email)
        {
            return email.EmailAddress;
        }
    }
}
