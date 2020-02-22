using Microsoft.AspNetCore.Mvc;
using RandomUser.Application;
using RandomUser.Application.Commands.DeleteUser;
using System;
using System.Threading.Tasks;


namespace RandomUser.WebApi.UseCases.DeleteUser
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IDeleteUserUseCase deleteUserService;

        public UserController(IDeleteUserUseCase deleteUserService)
        {
            this.deleteUserService = deleteUserService;
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            try
            {
                await deleteUserService.Execute(userId);
                return Ok();
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception)
            {
                return BadRequest($"Failed to delete user {userId}. User may not exist.");
            }
        }
    }
}
