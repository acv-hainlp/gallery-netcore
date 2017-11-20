using System.Collections.Generic;
using System.Threading.Tasks;
using gallery_netcore.Models;
using gallery_netcore.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gallery_netcore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly GalleryDbContext context;
        public CategoriesController(GalleryDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/categories")]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await context.Categories.ToListAsync();
        }
    }
}