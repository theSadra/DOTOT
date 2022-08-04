using WebApplication.Models.AddressingModels;

namespace WebApplication.Models
{

    public enum TripType { Private,MultiPassenger, PrivateAndMultiPassenger}
    public enum TripPlanStatus { OnSale, Done,Canceled}


    public class TripPlan
    {
        public int Id { get; set; }

        public DateTime StartingDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Decimal TicketPrice { get; set; }
        public string TripPlanCode { get; set; }


        public TripPlanStatus TripPlanStatus { get; set; }
        public TripType TripType { get; set; }
        public TaxiSupervisor TaxiSupervisor { get; set; }
        public CarModel CarModel { get; set; }
        public Location OriginLocation { get; set; }
        public Location DestinationLocation { get; set; }

        public IEnumerable<TripTicket> TripPlanTickets { get; set; }
    }
}
