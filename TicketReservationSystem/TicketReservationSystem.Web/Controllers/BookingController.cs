using System.Web.Mvc;
using TicketReservationSystem.Data.Repositories;

namespace TicketReservationSystem.Web.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRepository bookingRepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}