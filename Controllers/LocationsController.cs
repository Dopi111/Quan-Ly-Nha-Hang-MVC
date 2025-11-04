using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public IActionResult Index()
        {
            // Sample data - replace with database query later
            var locations = new List<Location>
            {
                new Location
                {
                    Id = 1,
                    Name = "COCÔTTE Sila",
                    Address = "123 Đường Lê Lợi, Quận 1",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 1234",
                    Email = "sila@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7769,106.7009",
                    ImageUrl = "/images/locations/sila.jpg",
                    Description = "Chi nhánh đầu tiên của COCÔTTE tại trung tâm Sài Gòn, mang đến không gian ấm cúng và các món ăn Pháp đặc sắc.",
                    OpeningTime = new TimeSpan(10, 0, 0),
                    ClosingTime = new TimeSpan(22, 0, 0),
                    IsActive = true
                },
                new Location
                {
                    Id = 2,
                    Name = "COCÔTTE Ben Thanh",
                    Address = "456 Lê Thánh Tôn, Quận 1",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 5678",
                    Email = "benthanh@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7723,106.6988",
                    ImageUrl = "/images/locations/benthanh.jpg",
                    Description = "Nằm gần chợ Bến Thành, chi nhánh này là điểm đến lý tưởng cho du khách và người dân địa phương.",
                    OpeningTime = new TimeSpan(9, 0, 0),
                    ClosingTime = new TimeSpan(23, 0, 0),
                    IsActive = true
                },
                new Location
                {
                    Id = 3,
                    Name = "COCÔTTE DaKao",
                    Address = "789 Võ Văn Tần, Quận 3",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 9012",
                    Email = "dakao@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7881,106.6917",
                    ImageUrl = "/images/locations/dakao.jpg",
                    Description = "Chi nhánh mới nhất với không gian hiện đại, phục vụ các món ăn Pháp fusion sáng tạo.",
                    OpeningTime = new TimeSpan(10, 30, 0),
                    ClosingTime = new TimeSpan(22, 30, 0),
                    IsActive = true
                }
            };

            return View(locations);
        }

        // GET: Locations/Detail/5
        public IActionResult Detail(int id)
        {
            // Sample data - replace with database query later
            var locations = new List<Location>
            {
                new Location
                {
                    Id = 1,
                    Name = "COCÔTTE Sila",
                    Address = "123 Đường Lê Lợi, Quận 1",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 1234",
                    Email = "sila@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7769,106.7009",
                    ImageUrl = "/images/locations/sila.jpg",
                    Description = "Chi nhánh đầu tiên của COCÔTTE tại trung tâm Sài Gòn, mang đến không gian ấm cúng và các món ăn Pháp đặc sắc. Với không gian rộng rãi, thoáng đãng và trang nhã, COCÔTTE Sila là nơi lý tưởng cho các bữa tiệc gia đình, gặp gỡ bạn bè hay các buổi hẹn hò lãng mạn.",
                    OpeningTime = new TimeSpan(10, 0, 0),
                    ClosingTime = new TimeSpan(22, 0, 0),
                    IsActive = true
                },
                new Location
                {
                    Id = 2,
                    Name = "COCÔTTE Ben Thanh",
                    Address = "456 Lê Thánh Tôn, Quận 1",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 5678",
                    Email = "benthanh@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7723,106.6988",
                    ImageUrl = "/images/locations/benthanh.jpg",
                    Description = "Nằm gần chợ Bến Thành, chi nhánh này là điểm đến lý tưởng cho du khách và người dân địa phương.",
                    OpeningTime = new TimeSpan(9, 0, 0),
                    ClosingTime = new TimeSpan(23, 0, 0),
                    IsActive = true
                },
                new Location
                {
                    Id = 3,
                    Name = "COCÔTTE DaKao",
                    Address = "789 Võ Văn Tần, Quận 3",
                    City = "Hồ Chí Minh",
                    Phone = "(028) 3825 9012",
                    Email = "dakao@cocotte.vn",
                    MapUrl = "https://maps.google.com/?q=10.7881,106.6917",
                    ImageUrl = "/images/locations/dakao.jpg",
                    Description = "Chi nhánh mới nhất với không gian hiện đại, phục vụ các món ăn Pháp fusion sáng tạo.",
                    OpeningTime = new TimeSpan(10, 30, 0),
                    ClosingTime = new TimeSpan(22, 30, 0),
                    IsActive = true
                }
            };

            var location = locations.FirstOrDefault(l => l.Id == id);

            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }
    }
}
