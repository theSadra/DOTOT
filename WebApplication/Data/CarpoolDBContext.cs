using Microsoft.EntityFrameworkCore;
using WebApplication.Models.AddressingModels;
using WebApplication.Models;



namespace Application.Data
{
    public class CarpoolDBContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<OTASeller> OTASellers { get; set; }
        public DbSet<TaxiSupervisor> TaxiSupervisors { get; set; }
        public DbSet<TripPlan> TripPlans { get; set; }
        public DbSet<TripTicket> TripTickets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> CityLocations { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\Carpooldev.db;");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
