namespace Visitor_Security_Clearance_System.Common
{
    public class Credentials
    {
        internal static readonly string databaseName=Environment.GetEnvironmentVariable("dataBaseName");
        internal static readonly string containerName= Environment.GetEnvironmentVariable("containerName");
        internal static readonly string CosmosEndPoint= Environment.GetEnvironmentVariable("cosmosURL");
        internal static readonly string PrimaryKey= Environment.GetEnvironmentVariable("primaryKey");
        internal static readonly string VisitorDocumentType;
        public static string UserDocumentType = "user";

    }
}
