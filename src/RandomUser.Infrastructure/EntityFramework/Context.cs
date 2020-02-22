using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RandomUser.Infrastructure.DataSeeding;
using RandomUser.Infrastructure.EntityFramework.Entities;

namespace RandomUser.Infrastructure.EntityFramework
{
    public class Context : DbContext
    {
       public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("Filename=../RandomUser.Infrastructure/users.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine("Adding users..");

            List<User> users = GenerateUsers.Generate();
                                         
            foreach (User user in users)
            {
               modelBuilder.Entity<User>().HasData(user);
            }
                        
        }

    }
}
