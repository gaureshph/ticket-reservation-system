using System.Threading.Tasks;
using System.Collections.Generic;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllAsync();
        Task<List<HotelRoom>> GetHotelRoomsAsync(int capacity, int hotelId);
    }
}
