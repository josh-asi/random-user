using System;
namespace RandomUser.Domain.User.ValueObjects
{
    public sealed class PhoneNumber
    {
        private int Number;

        public PhoneNumber(int number)
        {
            Number = number;
        }
    }
}
