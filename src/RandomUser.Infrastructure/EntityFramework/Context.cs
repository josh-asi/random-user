using System;
using Microsoft.EntityFrameworkCore;
using RandomUser.Infrastructure.EntityFramework.Entities;

namespace RandomUser.Infrastructure.EntityFramework
{
    public class Context : DbContext
    {
       public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("Filename=./users.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {
                    Id= 1,
                    Email = "john.doe@email.com",
                    DOB = DateTime.Now,
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Doe",
                    Image = "https://randomuser.me/api/portraits/men/33.jpg"
                });
        }

    }
}
