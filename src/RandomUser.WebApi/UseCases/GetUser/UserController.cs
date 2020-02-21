using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomUser.Application.Queries;
using RandomUser.Domain.User;


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

        [HttpGet("")]
        public int Hi()
        {
            return 1;
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {
            return await userQuery.GetUserAsync(id);
        }


    }
}
