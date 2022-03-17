using Microsoft.AspNetCore.Mvc;
using databaseconn.Models;

namespace databaseconn.Controllers
{
    public class RegionController : Controller
    {
        private  readonly NorthwindContext db;

        public RegionController(NorthwindContext context)
        {
            db = context;
        }

        public IActionResult Displaywithscaff()
        {
            List<Region> region = db.Regions.ToList();

            return View(region);
        }[HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Region region)
        {
            db.Regions.Add(region);
            db.SaveChanges();
            return RedirectToAction("Displaywithscaff");
        }


        [HttpGet]

        public IActionResult Edit(int id)
        {
            Region region = db.Regions.Find(id);
            return View(region);
        }
        [HttpPost]

        public IActionResult Edit(Region r)
        {
            Region region = db.Regions.Find(r.RegionId);
            region.RegionDescription = r.RegionDescription;
            db.SaveChanges();
            return RedirectToAction("Displaywithscaff");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                Region region = db.Regions.Find(id);
                db.Regions.Remove(region);
                db.SaveChanges();
                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("Displaywithscaff");
        }

        public IActionResult DisplayPerticularData(int id)
        {
            Region region = db.Regions.Find(id);
            return View(region);

        }
       


    }
}
