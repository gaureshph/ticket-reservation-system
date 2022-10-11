using System.Data.Entity;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.DbContexts
{
    public class TicketReservationSystemContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}