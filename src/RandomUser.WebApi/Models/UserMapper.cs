using RandomUser.Domain.User;
using System.Collections.Generic;
using System.Linq;

namespace RandomUser.WebApi.Models
{
    public class UserMapper
    {
        public static List<UserDTO> Map(List<User> users)
        {
            return users.Select(user => new UserDTO
            {
                Id = user.Id,
                Name = user.Name.FullName,
                DOB = user.DOB,
                Email = user.Email,
                Image = user.Image.Thumbnail,
                PhoneNumber = user.PhoneNumber
            }).ToList();
        }

        public static UserDTO Map(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name.FullName,
                DOB = user.DOB,
                Email = user.Email,
                Image = user.Image.DefaultLink,
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}
