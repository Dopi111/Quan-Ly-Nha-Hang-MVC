namespace WebNhaHang.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string SessionId { get; set; } = string.Empty;
        public int DishId { get; set; }
        public Dish? Dish { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? SpecialInstructions { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
