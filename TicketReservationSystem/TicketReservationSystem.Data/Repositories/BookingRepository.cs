using System.Threading.Tasks;
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

        public async Task CreateBooking(Booking booking)
        {
            ticketReservationSystemContext.Bookings.Add(booking);
            await ticketReservationSystemContext.SaveChangesAsync();
        }
    }
}
