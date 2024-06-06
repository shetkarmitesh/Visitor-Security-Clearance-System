using Nest;
using Visitor_Security_Clearance_System.Entities;
using Visitor_Security_Clearance_System.Interfaces;

namespace Visitor_Security_Clearance_System.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IRepository<Visitor> _visitorRepository;

        public VisitorService(IRepository<Visitor> visitorRepository)
        {
            _visitorRepository = visitorRepository;
        }

        public async Task<Visitor> RegisterVisitorAsync(Visitor visitor)
        {
            return await _visitorRepository.AddAsync(visitor);
        }

        public async Task<Visitor> GetVisitorByIdAsync(string id)
        {
            return await _visitorRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateVisitorAsync(Visitor visitor)
        {
            return await _visitorRepository.UpdateAsync(visitor);
        }

        public async Task<bool> DeleteVisitorAsync(string id)
        {
            return await _visitorRepository.DeleteAsync(id);
        }
    }
}
