namespace gallery_netcore.Models
{
    public class Category
    {
        public int Id { get; set; };
        public string title { get; set; }
        public string description { get; set; }

        public ICollection<Post> Posts { get; set; }

        public Category()
        {
            Posts = new Collection<Post>();
        }
    }
}