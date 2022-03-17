using Microsoft.AspNetCore.Mvc;
using databaseconn.Models;
namespace databaseconn.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;


        //Dependancy Injection
        public CategoryController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult GetCategory()

        {
            List<Category> category = db.Categories.ToList();
            return View(category);
        }

        #region Display
        public IActionResult GetCategorywithscaff()

        {
            List<Category> category = db.Categories.ToList();
            return View(category);
        }
        #endregion
        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();

            return RedirectToAction("GetCategorywithscaff");
        }


        #endregion

        #region Delete
    
        public IActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();

            return RedirectToAction("GetCategorywithscaff");
        }

        #endregion


        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category c)
        {
            Category category = db.Categories.Find(c.CategoryId);
            category.CategoryName = c.CategoryName;
            category.Description = c.Description;
            category.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");

        }
        #endregion

        public IActionResult Display(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }
    }
}
