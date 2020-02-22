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
            if (getNumberOfDigits(number) != LENGTH) throw new PhoneNumberShouldBe7DigitsException($"Phone numbers must have {LENGTH} digits");

            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }

        public static implicit operator int(PhoneNumber number)
        {
            return number.Number;
        }

        //public static implicit operator PhoneNumber(int v)
        //{
        //    return new PhoneNumber(v).Number;
        //}


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is double)
            {
                return (double)obj == Number;
            }

            return ((PhoneNumber)obj).Number == Number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private int getNumberOfDigits(int n)
        {
            int digits = n < 0 ? 2 : 1;
            while ((n /= 10) != 0) ++digits;
            return digits;
        }

    }
}
