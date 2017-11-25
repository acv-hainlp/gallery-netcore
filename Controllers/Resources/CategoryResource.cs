using System.Collections.Generic;
using System.Collections.ObjectModel;
using gallery_netcore.Controllers.Resources;

namespace gallery_netcore.Controllers.Resource
{
    public class CategoryResource
    {
        public int Id { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        public ICollection<PostResource> Posts { get; set; }

        public CategoryResource()
        {
            Posts = new Collection<PostResource>();
        }
    }
}