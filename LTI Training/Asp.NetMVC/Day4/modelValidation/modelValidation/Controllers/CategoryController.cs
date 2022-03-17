using Microsoft.AspNetCore.Mvc;
using modelValidation.Models;

namespace modelValidation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;

        public CategoryController(NorthwindContext Context)
        {
            db = Context;
        }
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
            return View();
        }
    }
}
