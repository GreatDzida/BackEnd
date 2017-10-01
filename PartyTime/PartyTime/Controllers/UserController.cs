using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyTime.Core;
using PartyTime.Infastructure;

namespace PartyTime.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody]User user)
        {
            await userService.RegisterAsync(Guid.NewGuid(), user.Email, user.Name, user.SurName,user.Login, user.Password, user.Phone);
            return Created("/account", null);
        }
    }
}
