using System.Threading.Tasks;
using System.Collections.Generic;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllAsync();
        Task<Hotel> GetAsync(int id);
        Task<List<HotelRoom>> GetHotelRoomsAsync(int capacity, int hotelId);
        Task<HotelRoom> GetHotelRoomAsync(int id);
    }
}
