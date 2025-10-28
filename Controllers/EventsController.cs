using Microsoft.AspNetCore.Mvc;

namespace WebNhaHang.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewData["Id"] = id;
            return View();
        }
    }
}


