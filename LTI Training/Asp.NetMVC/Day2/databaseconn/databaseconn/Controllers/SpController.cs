using Microsoft.AspNetCore.Mvc;
using databaseconn.Models;
using Microsoft.EntityFrameworkCore;

namespace databaseconn.Controllers
{
    public class SpController : Controller
    {
        private readonly NorthwindContext db;

        public SpController(NorthwindContext context)
        {
           db = context;
        }
        public IActionResult Tenproduct()
       
        {
            

            return View(db.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]"));
        }

        public IActionResult orders()
        {
            string? cid = "Vinet";

            var data = db.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders]");

            return View(data);
        }
    }
}
