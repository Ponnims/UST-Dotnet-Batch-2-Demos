using AuthenticationService.Models;
using AuthenticationService.Repository;
using AuthenticationService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository repo;
        private readonly ITokenGenerator tokengen;

        public AuthController(IUserRepository repo, ITokenGenerator tokengen)
        {
            this.repo = repo;
            this.tokengen = tokengen;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(User user)
        {
            repo.Register(user);
            return Ok("User Registered Successfully");
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var loggedInUser = repo.Login(user);
            if (loggedInUser == null)
                return StatusCode(401, "Invalid email or password");
            else

                return Ok(tokengen.GenerateToken(user.Email,loggedInUser.Role));
        }
    }
}
