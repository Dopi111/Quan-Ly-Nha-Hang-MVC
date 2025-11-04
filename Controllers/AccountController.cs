using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(ApplicationUser user, string password)
        {
            if (ModelState.IsValid)
            {
                // TODO: Hash password and save to database
                // For now, just simulate success
                TempData["SuccessMessage"] = "Đăng ký thành công! Vui lòng đăng nhập.";
                return RedirectToAction("Login");
            }

            return View(user);
        }

        // GET: Account/Login
        public IActionResult Login(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password, string? returnUrl = null)
        {
            // TODO: Validate credentials from database
            // For now, accept any login for demo purposes
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Simulate login success
                HttpContext.Session.SetString("UserEmail", email);
                HttpContext.Session.SetString("UserRole", "Customer");

                TempData["SuccessMessage"] = "Đăng nhập thành công!";

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("Profile");
            }

            ModelState.AddModelError("", "Email hoặc mật khẩu không đúng.");
            return View();
        }

        // GET: Account/Profile
        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login", new { returnUrl = "/Account/Profile" });
            }

            // TODO: Get user from database
            var user = new ApplicationUser
            {
                Email = email,
                FullName = "Sample User",
                Phone = "0123456789",
                Address = "123 Sample Street"
            };

            return View(user);
        }

        // POST: Account/UpdateProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProfile(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                // TODO: Update user in database
                TempData["SuccessMessage"] = "Cập nhật thông tin thành công!";
                return RedirectToAction("Profile");
            }

            return View("Profile", user);
        }

        // POST: Account/Logout
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["SuccessMessage"] = "Đã đăng xuất thành công!";
            return RedirectToAction("Index", "Home");
        }
    }
}
