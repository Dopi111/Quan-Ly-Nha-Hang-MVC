using Microsoft.AspNetCore.Mvc;
using WebNhaHang.Models;

namespace WebNhaHang.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public IActionResult Index()
        {
            // Sample cart data - replace with session/database later
            var cartItems = new List<CartItem>
            {
                new CartItem
                {
                    Id = 1,
                    DishId = 1,
                    Dish = new Dish
                    {
                        Id = 1,
                        Name = "Boeuf Bourguignon",
                        Price = 350000,
                        ImageUrl = "/images/dishes/boeuf.jpg"
                    },
                    Quantity = 2,
                    Price = 350000
                }
            };

            ViewBag.SubTotal = cartItems.Sum(item => item.Price * item.Quantity);
            ViewBag.DeliveryFee = 30000;
            ViewBag.Total = ViewBag.SubTotal + ViewBag.DeliveryFee;

            return View(cartItems);
        }

        // POST: Cart/Add
        [HttpPost]
        public IActionResult Add(int dishId, int quantity = 1)
        {
            // TODO: Add to session cart or database
            TempData["SuccessMessage"] = "Đã thêm món vào giỏ hàng!";
            return RedirectToAction("Index");
        }

        // POST: Cart/Update
        [HttpPost]
        public IActionResult Update(int itemId, int quantity)
        {
            // TODO: Update cart item quantity
            return RedirectToAction("Index");
        }

        // POST: Cart/Remove
        [HttpPost]
        public IActionResult Remove(int itemId)
        {
            // TODO: Remove item from cart
            TempData["SuccessMessage"] = "Đã xóa món khỏi giỏ hàng!";
            return RedirectToAction("Index");
        }

        // GET: Cart/Checkout
        public IActionResult Checkout()
        {
            // Sample cart data for checkout
            var cartItems = new List<CartItem>
            {
                new CartItem
                {
                    Id = 1,
                    DishId = 1,
                    Dish = new Dish
                    {
                        Id = 1,
                        Name = "Boeuf Bourguignon",
                        Price = 350000,
                        ImageUrl = "/images/dishes/boeuf.jpg"
                    },
                    Quantity = 2,
                    Price = 350000
                }
            };

            ViewBag.SubTotal = cartItems.Sum(item => item.Price * item.Quantity);
            ViewBag.DeliveryFee = 30000;
            ViewBag.Total = ViewBag.SubTotal + ViewBag.DeliveryFee;
            ViewBag.CartItems = cartItems;

            return View();
        }

        // POST: Cart/ProcessCheckout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProcessCheckout(Order order)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save order to database
                order.OrderNumber = "ORD" + DateTime.Now.Ticks.ToString().Substring(0, 10);
                order.Status = "Pending";

                TempData["SuccessMessage"] = "Đặt hàng thành công! Mã đơn hàng của bạn là: " + order.OrderNumber;
                return RedirectToAction("OrderConfirmation", new { orderNumber = order.OrderNumber });
            }

            return View("Checkout", order);
        }

        // GET: Cart/OrderConfirmation
        public IActionResult OrderConfirmation(string orderNumber)
        {
            // TODO: Get order from database
            var order = new Order
            {
                OrderNumber = orderNumber,
                CustomerName = "Sample Customer",
                Status = "Pending",
                Total = 730000
            };

            return View(order);
        }
    }
}
