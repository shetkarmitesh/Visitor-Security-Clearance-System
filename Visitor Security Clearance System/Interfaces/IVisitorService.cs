using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Interfaces
{
    public class IVisitorService
    {
        Task<Visitor> RegisterVisitorAsync(Visitor visitor);
        Task<Visitor> GetVisitorByIdAsync(string id);
        Task<bool> UpdateVisitorAsync(Visitor visitor);
        Task<bool> DeleteVisitorAsync(string id);
    }
}
