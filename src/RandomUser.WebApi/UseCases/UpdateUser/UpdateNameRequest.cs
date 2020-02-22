
using System.ComponentModel.DataAnnotations;

namespace RandomUser.WebApi.UseCases.UpdateUser
{
    public class UpdateNameRequest
    {
       [Required]
       public int UserId { get; set; }
       public string Title { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}
