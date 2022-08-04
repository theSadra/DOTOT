namespace WebApplication.Models.AddressingModels
{
    public class Location
    {
        public int ID { get; set; }
        public string LocationName { get; set; }

        public City City { get; set; }
    }
}
