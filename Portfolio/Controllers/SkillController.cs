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
    }
}
