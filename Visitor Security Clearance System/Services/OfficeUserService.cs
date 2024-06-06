﻿using Visitor_Security_Clearance_System.CosmosDBServices;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Entities;

namespace Visitor_Security_Clearance_System.Services
{
    public class OfficeUserService : IOfficeUserService
    {
        private readonly ICosmosService _cosmosDBService;

        public OfficeUserService()
        {
            _cosmosDBService = _cosmosDBService;
        }

        public async Task<OfficeUser> AddOfficeUserAsync(OfficeUser officeUser)
        {
            return await _cosmosDBService.AddOfficeUserAsync(officeUser);
        }

        public async Task<OfficeUser> GetOfficeUserByIdAsync(string uId)
        {
            return await _cosmosDBService.GetOfficeUserByIdAsync(uId);
        }

        public async Task<bool> UpdateOfficeUserAsync(OfficeUser officeUser)
        {
            return await _cosmosDBService.UpdateOfficeUserAsync(officeUser);
        }

        public async Task<bool> DeleteOfficeUserAsync(string uId)
        {
            return await _cosmosDBService.DeleteOfficeUserAsync(uId);
        }
    }
}
