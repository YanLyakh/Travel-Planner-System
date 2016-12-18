using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
   public class TravelDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Flight> Flightes { get; set; }
        public TravelDBContext() : base("TravelDB")
        { }
    }
}
