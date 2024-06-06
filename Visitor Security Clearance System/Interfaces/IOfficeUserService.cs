using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Interfaces
{
    public interface IOfficeUserService
    {
        Task<OfficeUser> AddOfficeUserAsync(OfficeUser officeUser);
        Task<OfficeUser> GetOfficeUserByIdAsync(string uId);
        Task<bool> UpdateOfficeUserAsync(OfficeUser officeUser);
        Task<bool> DeleteOfficeUserAsync(string uId);
    }
}
