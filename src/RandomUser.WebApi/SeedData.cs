using System;
using Microsoft.Extensions.DependencyInjection;
using RandomUser.Infrastructure.EntityFramework;
using RandomUser.Infrastructure.EntityFramework.Entities;

namespace RandomUser.WebApi
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<Context>();
            context.Database.EnsureCreated();
            if (!context.Items.Any())
            {
                //context.Items.Add(entity: new Item() { Name = "Green Thunder" });
                //context.Items.Add(entity: new Item() { Name = "Berry Pomegranate" });
                //context.Items.Add(entity: new Item() { Name = "Betty Crocker" });
                //context.Items.Add(entity: new Item() { Name = "Pizza Crust Mix" });

                
                new User
                {
                    Id = new Guid(),
                    Email = "john.doe@email.com",
                    DOB = DateTime.Now,
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Doe",
                    Image = "https://randomuser.me/api/portraits/men/33.jpg"
                }

                context.SaveChanges();
            }

            //if (!context.Shoppings.Any())
            //{
            //    context.Shoppings.Add(entity: new Shopping() { Name = "Defualt" });
            //}
        }
    }
}
