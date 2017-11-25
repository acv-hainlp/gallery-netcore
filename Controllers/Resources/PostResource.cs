using gallery_netcore.Models;

namespace gallery_netcore.Controllers.Resources
{
    public class PostResource
    {
        public int Id { get; set; }
        public int timestamp { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public string coverUrl { get; set; }
    }
}