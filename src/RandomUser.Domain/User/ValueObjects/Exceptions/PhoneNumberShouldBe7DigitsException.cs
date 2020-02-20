using System;
namespace RandomUser.Domain.User.ValueObjects.Exceptions
{
    public class PhoneNumberShouldBe7DigitsException : DomainException
    {
        internal PhoneNumberShouldBe7DigitsException(string message)
            : base(message)
        { }
    }
}
