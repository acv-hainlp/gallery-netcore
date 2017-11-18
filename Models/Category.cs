using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace gallery_netcore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required][StringLength(255)]
        public string title { get; set; }
        [StringLength(255)]
        public string description { get; set; }

        public ICollection<Post> Posts { get; set; }

        public Category()
        {
            Posts = new Collection<Post>();
        }
    }
}