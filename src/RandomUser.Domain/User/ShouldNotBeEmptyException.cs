using System;
namespace RandomUser.Domain.User
{
    public class ShouldNotBeEmptyException : Exception
    {
        internal ShouldNotBeEmptyException(string businessMessage)
              : base(businessMessage)
        {
        }
    }
}
