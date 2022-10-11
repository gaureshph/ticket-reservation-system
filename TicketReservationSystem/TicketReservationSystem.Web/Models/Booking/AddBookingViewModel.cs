namespace TicketReservationSystem.Web.Models.Booking
{
    public class AddBookingViewModel
    {
        public string CustomerName { get; set; }
        public int HotelRoomId { get; set; }
        public int NoOfPax { get; set; }
        public int NoOfDays { get; set; }
    }
}