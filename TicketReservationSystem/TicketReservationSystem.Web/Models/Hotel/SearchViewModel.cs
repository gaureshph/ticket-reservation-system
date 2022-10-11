using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace TicketReservationSystem.Web.Models.Hotel
{
    public class SearchViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NoOfPax { get; set; }
        public int HotelId { get; set; }
        public List<SelectListItem> Hotels { get; set; }
    }
}