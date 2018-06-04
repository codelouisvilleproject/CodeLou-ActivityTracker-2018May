using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ActivityTracker.Models;
using ActivityTracker.Database;

namespace ActivityTracker.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        public CategoriesController()
        {
            using (var context = new ActivityContext())
            {
                if(context.Categories.Where( x => x.Name  == "Cardio" ).Count() == 0)
                {
                    context.Categories.Add(new Categories { Name = "Cardio" });
                    context.SaveChanges();
                };

                if(context.Categories.Where( x => x.Name  == "Flexibility" ).Count() == 0)
                {
                    context.Categories.Add(new Categories { Name = "Flexibility" });
                    context.SaveChanges();     
                };

                if(context.Categories.Where( x => x.Name  == "CardioStrength" ).Count() == 0)
                {
                        context.Categories.Add(new Categories { Name = "CardioStrength" });
                        context.SaveChanges();
                };
            }
        }

        [HttpGet]
        public List<Categories> GetAll()
        {
            using (var context = new ActivityContext())
            {
                return context.Categories.ToList();
            }
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetById(long id)
        {
            using (var context = new ActivityContext())
            {
                var item = context.Categories.Find(id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
        }
    }
}