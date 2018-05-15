using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers
{
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryContext _context;

        public CategoriesController(CategoryContext context)
        {
            _context = context;

            if (_context.CategoriesItems.Count() == 0)
            {
                _context.CategoriesItems.Add(new CategoryItem { Name = "Item1" });
                _context.SaveChanges();
            }

            [HttpGet]
            public List<CategoryItem> GetAll()
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
}