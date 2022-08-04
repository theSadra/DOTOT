namespace WebApplication.Models
{
    public class OTASeller
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string NumberPhone { get; set; }
        public string? BackupNumberPhone { get; set; }
        public decimal BaseCommission { get; set; }
        public decimal AccountBalance { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime RegisteredDateTime { get; set; }
    }
}
