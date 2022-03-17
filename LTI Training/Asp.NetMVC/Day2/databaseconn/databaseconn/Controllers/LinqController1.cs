using Microsoft.AspNetCore.Mvc;
using databaseconn.Models;

namespace databaseconn.Controllers
{
    public class LinqController : Controller
    {
        private readonly NorthwindContext db;

        public LinqController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Getcatname()
        {

            //QuerySyntax 
            var catname = (from c in db.Categories
                           orderby c.CategoryName
                           select c.CategoryName).ToList();
            //method Systax

            var c1 = (db.Categories.Select(ca =>ca.CategoryName)).ToList();
            ViewBag.cname = catname;
            return View();
        }
        //Display Customer From germany

        public IActionResult CutomerGermany()
        {
            //query syntax
            ViewBag.Cust = (from c in db.Customers
                            where
     c.Country == "germany"
                            select c).ToList();
            return View();

        }
        //Display Employee whose region is notnull
        public IActionResult Employee()
        {
            ViewBag.employee = (from e in db.Employees
                                where e.Region != null
                                select e).ToList();
            return View();
        }

        //Display Cutomer info for order id 10248

        public IActionResult Custorders()
        {
            ViewBag.Cusromer = (from o in db.Orders
                                join c in db.Customers on 
                                o.CustomerId equals c.CustomerId
                                where o.OrderId == 10248
                                select c).ToList();

            return View();
        }

        public IActionResult fullname()
        {
            ViewBag.employee = (from e in db.Employees
                                select e.FirstName+ "" +e.LastName).ToList();

            return View();
        }

        //Display Customer details Who has Fax Number
        public IActionResult Cust()
        {
           var customer = (from c in db.Customers where c.Fax != null
                                select c).ToList();
            return View(customer);
        }


        //Displaying Second Letter Is U
        public IActionResult SecondLetter()
        {
            ViewBag.sletter = (from l in db.Employees
                               where l.FirstName[1]=='U'
                               select l).ToList();

            return View();
        }

        public IActionResult  unitprice()
        {
            var uprice = (from u in db.Products
                          where (u.UnitPrice > 10) || (u.UnitPrice<19) select u).ToList();
            return View(uprice);
        }

       //Display the order details which Contain shipping date arrange by the date 

        public IActionResult OrderbtShiiping()
        {
            var shippingdate = (from s in db.OrderDetails
                                select s).ToList();
            return View();
        }

    }
}
