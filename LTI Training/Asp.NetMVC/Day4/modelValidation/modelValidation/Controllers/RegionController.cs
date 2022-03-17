using Microsoft.AspNetCore.Mvc;
using modelValidation.Models;
namespace modelValidation.Controllers
{
    public class RegionController : Controller
    {
        private readonly NorthwindContext db;

        public RegionController(NorthwindContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Displaydetails()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Displaydetails(Region region)
        {
            db.Regions.Add(region);
            db.SaveChanges();
            return View();
        }

    }
}
