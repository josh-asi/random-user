using System;
namespace RandomUser.Domain.User.ValueObjects
{
    public sealed class Email
    {
        private string EmailAddress;

        public Email(string email)
        {
            EmailAddress = email;
        }
    }
}
