namespace Visitor_Security_Clearance_System.DTO
{
    public class VisitorDTO
    {
        public string VisitorId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Purpose { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
    }

    public class RequestModel : VisitorDTO
    {
        public string ApprovedStatus { get; set; }
    }
}
