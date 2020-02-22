using System;
using System.Collections.Generic;
using RandomUser.Domain.User;
using RandomUser.Domain.User.ValueObjects;

namespace RandomUser.Application.Tests
{
    public class UserGeneration
    {
        public static List<User> Generate()
        {
            var users = new List<User>();

            var id = 1;
            var name = new Name("Mr", "John", "Doe");
            var dob = DateTime.Now;
            var phone = new PhoneNumber(1234567);
            var email = new Email("john.doe@email.com");
            var image = new Image("default-image.jpg");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 2;
            name = new Name("Ms", "John", "Donor");
            dob = DateTime.Now;
            phone = new PhoneNumber(1234568);
            email = new Email("john.donor@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 3;
            name = new Name("Mr", "Jane", "Doe");
            dob = DateTime.Now;
            phone = new PhoneNumber(1234569);
            email = new Email("jane.doe@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 4;
            name = new Name("Mr", "Bob", "Dylan");
            dob = DateTime.Now;
            phone = new PhoneNumber(8673957);
            email = new Email("bob.dylan@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 5;
            name = new Name("Mr", "Robert", "Love");
            dob = DateTime.Now;
            phone = new PhoneNumber(7592648);
            email = new Email("robert.love@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            id = 6;
            name = new Name("Ms", "Daffey", "Duck");
            dob = DateTime.Now;
            phone = new PhoneNumber(6392759);
            email = new Email("daffey.duck@email.com");
            users.Add(new User(id, name, dob, phone, email, image));

            return users;
        }
    }
}
