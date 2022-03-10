using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public WorkController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Work> Get()
        {
            return _context.Works.ToList();
        }
    }
}
