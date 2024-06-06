using Visitor_Security_Clearance_System.CosmosDBServices;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Services
{
    public class ManagerService : IManagerService
    {
        private readonly ICosmosDBService _cosmosDBService;

        public  ManagerService()
        {
            _cosmosDBService = _cosmosDBService;
        }

        public async Task<Manager> AddManagerAsync(Manager manager)
        {
            return await _cosmosDBService.AddManagerAsync(manager);
        }

        public async Task<Manager> GetManagerByIdAsync(string uId)
        {
            return await _cosmosDBService.GetManagerByIdAsync(uId);
        }

        public async Task<bool> UpdateManagerAsync(Manager manager)
        {
            return await _cosmosDBService.UpdateManagerAsync(manager);
        }

        public async Task<bool> DeleteManagerAsync(string uId)
        {
            return await _cosmosDBService.DeleteManagerAsync(uId);
        }
    }
}
