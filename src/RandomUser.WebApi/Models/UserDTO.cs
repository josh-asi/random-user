using System;
namespace RandomUser.WebApi.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }
    }
}
