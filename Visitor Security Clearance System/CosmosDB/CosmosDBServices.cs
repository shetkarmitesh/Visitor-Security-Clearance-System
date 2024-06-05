using Microsoft.Azure.Cosmos;
using Visitor_Security_Clearance_System.Common;

namespace Visitor_Security_Clearance_System.CosmosDB
{
    public class CosmosDBServices : ICosmosDBServices
    {
        private readonly Container _container;
        public CosmosClient _cosmosClient;
        public CosmosDBServices(CosmosClient cosmosClient,string databaseName,string containerName) {
            _cosmosClient = new CosmosClient(Credentials.CosmosEndPoint, Credentials.PrimaryKey);
            _container = cosmosClient.GetContainer(Credentials.databaseName, Credentials.containerName);
        }
    }
}
