using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomUser.Application.Commands.UpdateUser;
using RandomUser.Domain.User;

namespace RandomUser.WebApi.UseCases.UpdateUser
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUpdateUserUseCase updateUserService;

        public UserController(IUpdateUserUseCase updateUserService)
        {
            this.updateUserService = updateUserService;
        }

        [HttpPost, Route("name")]
        public async Task<IActionResult> UpdateName([FromBody] UpdateNameRequest newName)
        {
            try
            {
                var name = new Name(newName.Title, newName.FirstName, newName.LastName);
                return new ObjectResult(await updateUserService.Execute(newName.UserId, name));
            }
            catch (Exception e)
            {
                return BadRequest($"Error updating name: {e.Message}");
            }
        }


    }
}
