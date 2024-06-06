using System.Threading.Tasks;
using Visitor_Security_Clearance_System.Interfaces;

namespace Visitor_Security_Clearance_System.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;

        public AuthenticationService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var user = await _userService.GetUserByUsername(username);
            if (user == null || user.Password != password)
                return false;

            return true;
        }
    }
}
