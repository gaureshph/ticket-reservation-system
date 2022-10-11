using System.Threading.Tasks;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public interface IBookingRepository
    {
        Task CreateBooking(Booking booking);
    }
}
