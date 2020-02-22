using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomUser.Application.Queries;
using RandomUser.Infrastructure.EntityFramework;
using RandomUser.WebApi.Models;


namespace RandomUser.WebApi.UseCases.GetUsers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserQuery userQuery;

        public UserController(IUserQuery userQuery)
        {
            this.userQuery = userQuery;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetUsersAsync()
        {
            try
            {
                var result = await userQuery.GetUsersAsync();
                return new ObjectResult(UserMapper.Map(result));
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

        [HttpGet("{limit}")]
        public async Task<IActionResult> GetUsersAsync(int limit)
        {
            try
            {
                var result = await userQuery.GetUsersAsync(limit);
                return new ObjectResult(UserMapper.Map(result));
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

        [HttpGet("first-name/{name}")]
        public async Task<IActionResult> GetUsersByFirstNameAsync(string name)
        {
            try
            {
                var result = await userQuery.GetUsersByFirstNameAsync(name);
                return new ObjectResult(UserMapper.Map(result));
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

        [HttpGet("last-name/{name}")]
        public async Task<IActionResult> GetUsersByLastNameAsync(string name)
        {
            try
            {
                var result = await userQuery.GetUsersByLastNameAsync(name);
                return new ObjectResult(UserMapper.Map(result));
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
