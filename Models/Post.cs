using System.ComponentModel.DataAnnotations;

namespace gallery_netcore.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public int timestamp { get; set; }
        [Required][StringLength(255)]
        public string title { get; set; }
        [StringLength(255)]
        public string description { get; set; }
        public bool isActive { get; set; }
        public string coverUrl { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}