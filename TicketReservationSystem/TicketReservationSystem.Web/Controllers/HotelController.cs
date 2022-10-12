using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;
using TicketReservationSystem.Web.Models.Hotel;
using TicketReservationSystem.Data.Repositories;

namespace TicketReservationSystem.Web.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelRepository hotelRepository;
        public HotelController(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Search()
        {
            var hotels = await hotelRepository.GetAllAsync();
            var searchViewModel = new SearchViewModel
            {
                Hotels = hotels.Select(hotel => new SelectListItem { Value = hotel.Id.ToString(), Text = hotel.Name }).ToList()
            };
            return View(searchViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Search(SearchViewModel searchViewModel)
        {
            if (ModelState.IsValid)
            {
                var rooms = await hotelRepository.GetHotelRoomsAsync(searchViewModel.NoOfPax ,searchViewModel.HotelId);
                var hotel = await hotelRepository.GetAsync(searchViewModel.HotelId);

                var searchResultsViewModel = rooms.Select(room => new SearchResultViewModel
                {
                    HotelId = room.HotelId,
                    HotelName = hotel.Name,
                    HotelRoomId = room.Id,
                    HotelRoomName = room.Name,
                    NoOfPax = room.Capacity
                });
                return View("SearchResults", searchResultsViewModel);
            }

            var hotels = await hotelRepository.GetAllAsync();
            searchViewModel.Hotels = hotels.Select(hotel => new SelectListItem { Value = hotel.Id.ToString(), Text = hotel.Name }).ToList();
            return View(searchViewModel);
        }
    }
}