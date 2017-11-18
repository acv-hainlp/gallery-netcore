using Microsoft.EntityFrameworkCore;

namespace gallery_netcore.Persistence
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options) : base(options)
        {
            
        }
    }
}