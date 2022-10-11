namespace TicketReservationSystem.Data.DbEntities
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int HotelRoomId { get; set; }
        public int NoOfPax { get; set; }
        public int NoOfDays { get; set; }
    }
}
