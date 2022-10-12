using System.Threading.Tasks;
using System.Collections.Generic;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public interface IBookingRepository
    {
        Task CreateBookingAsync(Booking booking);
        Task<List<Booking>> GetAllAsync();
    }
}
