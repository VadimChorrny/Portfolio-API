using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BlogController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _context.Blogs.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Blog> Get(int id)
        {
            if(id == 0) return NotFound();
            return _context.Blogs.SingleOrDefault(blog => blog.Id == id);
        }

    }
}
