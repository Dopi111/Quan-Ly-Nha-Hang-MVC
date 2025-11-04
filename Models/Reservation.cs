namespace WebNhaHang.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        public int NumberOfGuests { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public string? SpecialRequests { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Cancelled
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
