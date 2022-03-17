using Microsoft.AspNetCore.Mvc;
using modelValidation.VM;
using modelValidation.Models;
namespace modelValidation.Controllers
{
    public class VMController : Controller
    {
        private readonly NorthwindContext db;

        public VMController(NorthwindContext context)
        {
            db = context;
        }

        public IActionResult CustomerOrder()
        {
            List<CustomerVM> li = new List<CustomerVM>();

            var customerlist=(from cust in db.Customers join 
                              or in db.Orders on cust.CustomerId equals or.CustomerId   
                           select new {cust.CustomerId,cust.CompanyName,or.OrderId,or.OrderDate}).ToList();
           
                foreach(var item in customerlist)
            {
                CustomerVM cvm = new CustomerVM();

                cvm.OrderId = item.OrderId;
                cvm.CustomerId = item.CustomerId;
                cvm.CompanyName = item.CompanyName;
                cvm.OrderDate = item.OrderDate;


                li.Add(cvm);
            }
            
            return View(li);
        }
    }
}
