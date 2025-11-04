namespace WebNhaHang.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string Category { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
        public bool IsFeatured { get; set; } = false;
        public string? Ingredients { get; set; }
        public int PreparationTime { get; set; } // in minutes
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
