using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Swarupa.Models;
using WebApi_Swarupa.Service;

namespace WebApi_Swarupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login model)
        {
            // Authenticate user (e.g., validate username and password)
            if (model.Username == "jyothi" && model.Password == "12345")
            {
                var token = _tokenService.GenerateJwtToken(model.Username, "Admin");
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

    }
}

