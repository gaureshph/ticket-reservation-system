namespace TicketReservationSystem.Web.Models.Booking
{
    public class BookingViewModel
    {
        public string CustomerName { get; set; }
        public string HotelRoomName { get; set; }
        public int NoOfPax { get; set; }
        public int NoOfDays { get; set; }
    }
}