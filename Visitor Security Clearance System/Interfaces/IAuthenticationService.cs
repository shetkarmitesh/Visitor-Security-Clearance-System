using System.Threading.Tasks;

namespace Visitor_Security_Clearance_System.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string username, string password);
    }
}
