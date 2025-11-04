namespace WebNhaHang.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string? ImageUrl { get; set; }
        public string Venue { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public int MaxCapacity { get; set; }
        public int CurrentRegistrations { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public string Category { get; set; } = string.Empty; // Catering, Workshop, Special Event
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
