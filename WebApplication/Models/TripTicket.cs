namespace WebApplication.Models
{
    public class TripTicket
    {
        public int ID { get; set; }
        public DateTime RegisteredDateTime { get; set; }
        public string TripTicketCode { get; set; }
        public int? SeatNumber { get; set; }
        public bool IsPrivateTrip { get; set; }

        public OTASeller OTASellerRegisteredby { get; set; }
        public Passenger Passenger { get; set; }
    }
}
