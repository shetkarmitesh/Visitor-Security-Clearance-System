using Visitor_Security_Clearance_System.Entities;

namespace VisitorSecurityClearanceSystemAPI.Interfaces
{
    public interface IManagerService
    {
        Task<Manager> AddManagerAsync(Manager manager);
        Task<Manager> GetManagerByIdAsync(string uId);
        Task<bool> UpdateManagerAsync(Manager manager);
        Task<bool> DeleteManagerAsync(string uId);
    }
}
