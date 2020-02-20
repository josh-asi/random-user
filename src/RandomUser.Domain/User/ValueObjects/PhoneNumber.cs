using System;
using RandomUser.Domain.User.ValueObjects.Exceptions;

namespace RandomUser.Domain.User.ValueObjects
{
    public sealed class PhoneNumber
    {
        private int Number;
        private readonly int LENGTH = 7;

        public PhoneNumber(int number)
        {
            if (number < 0) throw new InvalidFormatException("Phone numbers cannot be negative");
            if (number.ToString().Length != LENGTH) throw new PhoneNumberShouldBe7DigitsException($"Phone numbers must have {LENGTH} digits");

            Number = number;
        }

        public static implicit operator int(PhoneNumber number)
        {
            return number.Number;
        }

    }
}
