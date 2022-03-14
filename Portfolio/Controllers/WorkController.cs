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
        [HttpPost]
        public IActionResult Post(Work model)
        {
            _context.Works.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var workToDelete = _context.Works.FirstOrDefault(e => e.Id == id);
            if (workToDelete == null)
                return NotFound();
            _context.Works.Remove(workToDelete);
            _context.SaveChanges();
            return Ok(workToDelete);
        }
    }
}
