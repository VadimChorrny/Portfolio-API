using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        ApplicationContext _context;
        public SkillController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet] // maybe need change
        public IEnumerable<Skill> Get()
        {
            return _context.Skills.ToList();
        }
        [HttpGet("{id:int}")]
        public ActionResult<Skill> Get(int id)
        {
            if (id == 0) return NotFound();
            return _context.Skills.FirstOrDefault(blog => blog.Id == id);
        }
        [HttpPost]
        public IActionResult Post(Skill model)
        {
            _context.Skills.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var skillToDelete = _context.Skills.FirstOrDefault(e => e.Id == id);
            if (skillToDelete == null)
                return NotFound();
            _context.Skills.Remove(skillToDelete);
            _context.SaveChanges();
            return Ok(skillToDelete);
        }
        [HttpPut]
        public IActionResult Put(Skill model)
        {
            _context.Skills.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
    }
}
