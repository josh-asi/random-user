using System;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Domain.User
{
    public sealed class User
    {
        public Guid Id { get; private set; }
        public Name Name {get; private set;}
        public DateTime DOB { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public Image Image { get; private set; }

        public User(Name name, DateTime dob, PhoneNumber number, Image image)
        {
            Id = new Guid();
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
