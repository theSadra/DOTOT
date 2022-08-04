namespace WebApplication.Models
{

    public enum CarType { FourDor,Van}
    public class CarModel
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public CarType CarType { get; set; }
        public int NumberOfSeates { get; set; }
        
    }
}
