using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Interfaces
{
    public interface ISecurityUserService
    {
        Task<SecurityUser> AddSecurityUserAsync(SecurityUser securityUser);
        Task<SecurityUser> GetSecurityUserByIdAsync(string uId);
        Task<bool> UpdateSecurityUserAsync(SecurityUser securityUser);
        Task<bool> DeleteSecurityUserAsync(string uId);
    }
}
