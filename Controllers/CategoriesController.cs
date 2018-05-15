using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoriesContext _context;

        public CategoriesController(CategoriesContext context)
        {
            _context = context;

            if (_context.CategoriesItems.Count() == 0)
            {
                _context.CategoriesItems.Add(new CategoriesItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<CategoriesItem> GetAll()
        {
            return _context.CategoriesItems.ToList();
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetById(long id)
        {
            var item = _context.CategoriesItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }       
    }
}