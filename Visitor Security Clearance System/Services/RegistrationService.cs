using Visitor_Security_Clearance_System.CosmosDB;
using Visitor_Security_Clearance_System.Interfaces;

namespace Visitor_Security_Clearance_System.Services
{
    public class RegistrationService :  IRegistrationService
    {
        public readonly ICosmosDBServices _cosmosDBServices;

        public RegistrationService(ICosmosDBServices cosmosDBServices) { 
            _cosmosDBServices = cosmosDBServices;

        }
    }
}
