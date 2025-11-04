namespace WebNhaHang.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Author { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; } = DateTime.Now;
        public string Category { get; set; } = string.Empty;
        public string[] Tags { get; set; } = Array.Empty<string>();
        public bool IsPublished { get; set; } = true;
    }
}
