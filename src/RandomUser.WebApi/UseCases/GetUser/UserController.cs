using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomUser.Application.Queries;
using RandomUser.Infrastructure.EntityFramework;
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
                var result = await userQuery.GetUserAsync(id);
                var user = new UserDTO
                {
                    Id = id,
                    Email = result.Email,
                    DOB = result.DOB,
                    Name = result.Name.FullName,
                    Image = result.Image.DefaultLink,
                    PhoneNumber = result.PhoneNumber
                };
                return new ObjectResult(user);                   
            } catch (NotFoundException e)
            {
                return NotFound(e.Message);
            } catch (Exception e)
            {
                return BadRequest($"Error: {e.Message}");
            }
        }


    }
}
