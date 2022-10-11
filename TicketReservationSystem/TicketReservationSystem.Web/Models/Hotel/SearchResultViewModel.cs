namespace TicketReservationSystem.Web.Models.Hotel
{
    public class SearchResultViewModel
    {
        public int HotelId { get; set; }
        public int HotelRoomId { get; set; }
        public int NoOfPax { get; set; }
        public string HotelName { get; set; }
        public string HotelRoomName { get; set; }
    }
}