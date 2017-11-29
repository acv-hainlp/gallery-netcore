using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using gallery_netcore.Controllers.Resource;
using gallery_netcore.Models;
using gallery_netcore.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gallery_netcore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly GalleryDbContext context;
        private readonly IMapper mapper;
        public CategoriesController(GalleryDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/categories")]
        [Authorize]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
            var categories = await context.Categories.Include(c => c.Posts).ToListAsync();

            return mapper.Map<List<Category>, List<CategoryResource>>(categories);
        }
    }
}