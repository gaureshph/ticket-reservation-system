using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketReservationSystem.Web.Models.Hotel
{
    public class SearchViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        [Range(1, int.MaxValue)]
        public int NoOfPax { get; set; }
        public int HotelId { get; set; }
        public List<SelectListItem> Hotels { get; set; }
    }
}