using System;
using RandomUser.Domain.User.ValueObjects;
using RandomUser.Domain.User.ValueObjects.Exceptions;

namespace RandomUser.Domain.User
{
    public sealed class User
    {
        public int Id { get; private set; }
        public Name Name {get; private set;}
        public DateTime DOB { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public Image Image { get; private set; }

        public User(int id , Name name, DateTime dob, PhoneNumber number, Image image)
        {

            if (id < 0) throw new InvalidFormatException("User Id must not be a negative number");

            Id = id;
            Name = name;
            DOB = dob;
            PhoneNumber = number;
            Image = image;
        }

        //public User UpdateName(Name newName)
        //{
        //    return this;
        //}

        public void DeleteUser()
        {
            // Do Something
        }
    }
}
