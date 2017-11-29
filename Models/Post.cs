using System;
using System.ComponentModel.DataAnnotations;

namespace gallery_netcore.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public DateTime CreateOn { get; set; }
        [Required][StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CoverUrl { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; } 
    }
}