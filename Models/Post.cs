namespace gallery_netcore.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int timestamp { get; set; }
        public string title { get; set; }

        public string description { get; set; }
        public bool isActive { get; set; }
        public string coverUrl { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}