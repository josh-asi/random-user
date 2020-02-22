using RandomUser.Infrastructure.EntityFramework.Entities;
using System;
using System.Collections.Generic;

namespace RandomUser.Infrastructure.DataSeeding
{
    public class GenerateUsers
    {

        private static int LENGTH = Math.Min(Surnames.surnames.Length, Math.Min(FemaleNames.names.Length, MaleNames.names.Length));

        public static List<User> Generate()
        {
            var users = new List<User>();

            for (int i = 1; i < LENGTH; i++)
            {

                string title = new Random().Next(0, 2) == 0 ? "Mr" : "Ms";
                string firstName = title == "Mr" ? MaleNames.names[index()] : FemaleNames.names[index()];
                string lastName = Surnames.surnames[index()];

                string email = $"{firstName}.{lastName}@email.com";
                string image = $"https://randomuser.me/api/portraits/{(title == "Mr" ? "men" : "women")}/{i}.jpg";

                int phoneNumber = new Random().Next(1000000, 9999999);

                users.Add(new User
                {
                    Id = i,
                    DOB = DateTime.Now,
                    Title = title,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Image = image,
                    PhoneNumber = phoneNumber
                });
            }
                       
            return users;

        }

        private static int index()
        {
            return new Random().Next(0, LENGTH);
        }
        
    }
}
 