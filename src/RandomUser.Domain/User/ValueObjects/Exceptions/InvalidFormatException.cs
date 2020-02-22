using System;
namespace RandomUser.Domain.User.ValueObjects.Exceptions
{
    public class InvalidFormatException : DomainException
    {
        internal InvalidFormatException(string businessMessage)
            : base(businessMessage)
        {
        }
    }
}
