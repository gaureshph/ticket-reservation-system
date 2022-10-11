namespace TicketReservationSystem.Data.DbEntities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HotelId { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
    }
}
