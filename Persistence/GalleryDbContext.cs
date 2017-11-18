using gallery_netcore.Models;
using Microsoft.EntityFrameworkCore;

namespace gallery_netcore.Persistence
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}