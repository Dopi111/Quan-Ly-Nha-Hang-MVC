using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public IActionResult Index()
        {
            // Get locations for dropdown
            var locations = new List<Location>
            {
                new Location { Id = 1, Name = "COCÔTTE Sila" },
                new Location { Id = 2, Name = "COCÔTTE Ben Thanh" },
                new Location { Id = 3, Name = "COCÔTTE DaKao" }
            };

            ViewBag.Locations = locations;
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save to database
                // For now, just redirect to confirmation
                TempData["SuccessMessage"] = "Đặt bàn thành công! Chúng tôi sẽ liên hệ với bạn sớm để xác nhận.";
                return RedirectToAction("Confirmation", new { id = reservation.Id });
            }

            // If model is invalid, return to form
            var locations = new List<Location>
            {
                new Location { Id = 1, Name = "COCÔTTE Sila" },
                new Location { Id = 2, Name = "COCÔTTE Ben Thanh" },
                new Location { Id = 3, Name = "COCÔTTE DaKao" }
            };

            ViewBag.Locations = locations;
            return View("Index", reservation);
        }

        // GET: Reservation/Confirmation
        public IActionResult Confirmation(int id)
        {
            // TODO: Get reservation from database
            var reservation = new Reservation
            {
                Id = id,
                CustomerName = "Sample Customer",
                CustomerEmail = "customer@example.com",
                ReservationDate = DateTime.Now.AddDays(1),
                NumberOfGuests = 4,
                Status = "Pending"
            };

            return View(reservation);
        }
    }
}
