using Microsoft.AspNetCore.Mvc;


namespace Visitor_Security_Clearance_System.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO)
        {
            var isAuthenticated = await _authenticationService.Authenticate(model.Username, model.Password);
            if (!isAuthenticated)
                return Unauthorized("Invalid username or password.");

            return Ok("Login successful.");
        }
    }
}