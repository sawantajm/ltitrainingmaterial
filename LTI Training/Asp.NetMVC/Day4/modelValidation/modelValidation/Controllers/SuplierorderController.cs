using Microsoft.AspNetCore.Mvc;
using modelValidation.Models;
using modelValidation.VM;

namespace modelValidation.Controllers
{
    
    public class SuplierorderController : Controller
    {
        private readonly NorthwindContext db;

        public SuplierorderController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult suplierorder()

        {
            List<supliersorders> li = new List<supliersorders>();

            var suporder = (from sup in db.Suppliers join
                            pr in db.Products on  sup.SupplierId equals pr.SupplierId
                            select new {sup.CompanyName,pr.ProductName,sup.SupplierId} ).ToList();



            foreach(var su in suporder)
            {
                supliersorders suplierorder = new supliersorders();

                suplierorder.CompanyName = su.CompanyName;
                suplierorder.ProductName = su.ProductName;
                suplierorder.SupplierId = su.SupplierId;
                li.Add(suplierorder);
            }
            return View(li);
        }
    }
}
