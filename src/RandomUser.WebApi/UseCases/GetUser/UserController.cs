using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomUser.Application;
using RandomUser.Application.Queries;
using RandomUser.WebApi.Models;

namespace RandomUsers.WebApi.UseCases.GetUser
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserQuery userQuery;

        public UserController(IUserQuery userQuery)
        {
            this.userQuery = userQuery;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            try
            {
                var user = await userQuery.GetUserAsync(id);
                return new ObjectResult(UserMapper.Map(user));                   
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest($"Error: {e.Message}");
            }
        }


    }
}
