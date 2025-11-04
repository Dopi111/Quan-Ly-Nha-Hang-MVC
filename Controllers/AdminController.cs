using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        public IActionResult Login(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password, string? returnUrl = null)
        {
            // TODO: Validate admin credentials from database
            // Hardcoded admin for demo: admin@cocotte.vn / admin123
            if (email == "admin@cocotte.vn" && password == "admin123")
            {
                HttpContext.Session.SetString("AdminEmail", email);
                HttpContext.Session.SetString("UserRole", "Admin");

                TempData["SuccessMessage"] = "Đăng nhập Admin thành công!";

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("Dashboard");
            }

            ModelState.AddModelError("", "Email hoặc mật khẩu không đúng.");
            return View();
        }

        // GET: Admin/Dashboard
        public IActionResult Dashboard()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login", new { returnUrl = "/Admin/Dashboard" });
            }

            // Sample statistics
            ViewBag.TotalOrders = 150;
            ViewBag.TotalReservations = 45;
            ViewBag.TotalRevenue = 125000000;
            ViewBag.TodayOrders = 12;

            return View();
        }

        // GET: Admin/ManageMenu
        public IActionResult ManageMenu()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login");
            }

            // Sample dishes
            var dishes = new List<Dish>
            {
                new Dish { Id = 1, Name = "Boeuf Bourguignon", Price = 350000, Category = "Main Course", IsAvailable = true },
                new Dish { Id = 2, Name = "Coq au Vin", Price = 320000, Category = "Main Course", IsAvailable = true },
                new Dish { Id = 3, Name = "Ratatouille", Price = 280000, Category = "Main Course", IsAvailable = true }
            };

            return View(dishes);
        }

        // GET: Admin/ManageReservations
        public IActionResult ManageReservations()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login");
            }

            // Sample reservations
            var reservations = new List<Reservation>
            {
                new Reservation
                {
                    Id = 1,
                    CustomerName = "Nguyễn Văn A",
                    CustomerEmail = "nguyenvana@example.com",
                    ReservationDate = DateTime.Now.AddDays(1),
                    NumberOfGuests = 4,
                    Status = "Pending"
                }
            };

            return View(reservations);
        }

        // GET: Admin/ManageOrders
        public IActionResult ManageOrders()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login");
            }

            // Sample orders
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    OrderNumber = "ORD1234567890",
                    CustomerName = "Trần Thị B",
                    Total = 730000,
                    Status = "Pending",
                    OrderDate = DateTime.Now
                }
            };

            return View(orders);
        }

        // GET: Admin/ManageBlogs
        public IActionResult ManageBlogs()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login");
            }

            // Sample blog posts
            var posts = new List<BlogPost>
            {
                new BlogPost
                {
                    Id = 1,
                    Title = "Bí quyết chế biến món Pháp",
                    Author = "Chef Pierre",
                    PublishedDate = DateTime.Now.AddDays(-5),
                    IsPublished = true
                }
            };

            return View(posts);
        }

        // GET: Admin/ManageEvents
        public IActionResult ManageEvents()
        {
            if (!IsAdminLoggedIn())
            {
                return RedirectToAction("Login");
            }

            // Sample events
            var events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Title = "French Cooking Workshop",
                    EventDate = DateTime.Now.AddDays(7),
                    MaxCapacity = 20,
                    CurrentRegistrations = 8,
                    IsActive = true
                }
            };

            return View(events);
        }

        // POST: Admin/Logout
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["SuccessMessage"] = "Đã đăng xuất khỏi Admin!";
            return RedirectToAction("Login");
        }

        // Helper method to check if admin is logged in
        private bool IsAdminLoggedIn()
        {
            var role = HttpContext.Session.GetString("UserRole");
            return role == "Admin";
        }
    }
}
