using System.Web.Mvc;
using System.Threading.Tasks;
using TicketReservationSystem.Data.Repositories;
using TicketReservationSystem.Web.Models.Booking;
using TicketReservationSystem.Data.DbEntities;
using System.Linq;
using System.Collections.Generic;

namespace TicketReservationSystem.Web.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRepository bookingRepository;
        private readonly IHotelRepository hotelRepository;
        public BookingController(IBookingRepository bookingRepository, IHotelRepository hotelRepository)
        {
            this.bookingRepository = bookingRepository;
            this.hotelRepository = hotelRepository;
        }

        public async Task<ActionResult> Index()
        {
            var bookings = await bookingRepository.GetAllAsync();
            var bookingsViewModel = new List<BookingViewModel>();
            foreach(var booking in bookings)
            {
                var bookingViewModel = new BookingViewModel
                {
                    CustomerName = booking.CustomerName,
                    NoOfDays = booking.NoOfDays,
                    NoOfPax = booking.NoOfPax,
                    HotelRoomName = (await hotelRepository.GetHotelRoomAsync(booking.HotelRoomId)).Name
                };
                bookingsViewModel.Add(bookingViewModel);
            }

            return View(bookingsViewModel);
        }

        [HttpGet]
        public async Task<ActionResult> Create(int id)
        {
            var room = await hotelRepository.GetHotelRoomAsync(id);
            var addBookingViewModel = new AddBookingViewModel
            {
                HotelRoomId = room.Id,
                NoOfPax = room.Capacity,
                HotelRoomName = room.Name
            };

            return View(addBookingViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(AddBookingViewModel addBookingViewModel)
        {
            if(ModelState.IsValid)
            {
                var booking = new Booking
                {
                    CustomerName = addBookingViewModel.CustomerName,
                    HotelRoomId = addBookingViewModel.HotelRoomId,
                    NoOfDays = addBookingViewModel.NoOfDays,
                    NoOfPax = addBookingViewModel.NoOfPax
                };
                await bookingRepository.CreateBookingAsync(booking);

                return RedirectToAction("Index");
            }

            return View(addBookingViewModel);
        }
    }
}