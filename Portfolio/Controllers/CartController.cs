using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ApplicationContext _context;
        public CartController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet] // maybe need change
        public IEnumerable<Cart> Get()
        {
            return _context.Carts.ToList();
        }
        [HttpPost]
        public IActionResult Post(Cart model)
        {
            _context.Carts.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var nftToDelete = _context.Carts.FirstOrDefault(e => e.Id == id);
            if (nftToDelete == null)
                return NotFound();
            _context.Carts.Remove(nftToDelete);
            _context.SaveChanges();
            return Ok(nftToDelete);
        }
    }
}
