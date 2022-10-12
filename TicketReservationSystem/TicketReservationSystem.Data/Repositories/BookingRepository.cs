using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;
using TicketReservationSystem.Data.DbContexts;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly TicketReservationSystemContext ticketReservationSystemContext;
        public BookingRepository(TicketReservationSystemContext ticketReservationSystemContext)
        {
            this.ticketReservationSystemContext = ticketReservationSystemContext;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            ticketReservationSystemContext.Bookings.Add(booking);
            await ticketReservationSystemContext.SaveChangesAsync();
        }

        public async Task<List<Booking>> GetAllAsync()
        {
            return await ticketReservationSystemContext.Bookings.ToListAsync();
        }
    }
}
