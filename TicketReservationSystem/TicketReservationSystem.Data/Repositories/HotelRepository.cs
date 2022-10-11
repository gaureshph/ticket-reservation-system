﻿using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;
using TicketReservationSystem.Data.DbContexts;
using TicketReservationSystem.Data.DbEntities;

namespace TicketReservationSystem.Data.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly TicketReservationSystemContext ticketReservationSystemContext;
        public HotelRepository(TicketReservationSystemContext ticketReservationSystemContext)
        {
            this.ticketReservationSystemContext = ticketReservationSystemContext;
        }

        public async Task<List<Hotel>> GetAllAsync()
        {
            return await ticketReservationSystemContext.Hotels.ToListAsync();
        }

        public async Task<List<HotelRoom>> GetHotelRoomsAsync(int capacity, int hotelId)
        {
            var rooms = ticketReservationSystemContext.HotelRooms;
            if (capacity > 0)
                rooms.Where(room => room.Capacity == capacity);
            if (hotelId > 0)
                rooms.Where(room => room.HotelId == hotelId);
            return await rooms.ToListAsync();
        }
    }
}
