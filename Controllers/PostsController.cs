using gallery_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace gallery_netcore.Controllers
{
    [Route("/api/posts")]
    public class PostsController : Controller
    {
        [HttpPost]
        public IActionResult CreatePost([FromBody] Post post) 
        {
            return Ok(post);
        }
    }
}