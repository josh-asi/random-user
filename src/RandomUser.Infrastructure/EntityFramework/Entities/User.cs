using System;
using System.ComponentModel.DataAnnotations;

namespace RandomUser.Infrastructure.EntityFramework.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }
        
    }
}
