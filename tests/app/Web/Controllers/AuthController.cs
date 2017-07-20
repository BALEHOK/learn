using Microsoft.AspNetCore.Mvc;
using Data;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly DataContext _dbContext;
        public AuthController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public async Task<dynamic> Login([FromBody]LoginModel model)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (user != null)
            {
                var accessToken = Guid.NewGuid().ToString();
                user.AccessToken = accessToken;
                await _dbContext.SaveChangesAsync();

                return new
                {
                    AccessToken = accessToken
                };
            }

            return new
            {
                Error = "Wrong credentials"
            };
        }

        // [Auth]
        // [HttpGet("logout")]
        // public async Task<StatusCodeResult> Logout()
        // {
        //     var user = HttpContext.GetUser();
        //     user.AccessToken = string.Empty;
        //     await _dbContext.SaveChangesAsync();
        //     return Ok();
        // }

        // [Auth]
        // [HttpGet("userinfo")]
        // public object UserInfo()
        // {
        //     var user = HttpContext.GetUser();
        //     return user;
        // }
    }
}
