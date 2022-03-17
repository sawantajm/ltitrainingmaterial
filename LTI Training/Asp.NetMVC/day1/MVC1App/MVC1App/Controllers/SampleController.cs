using Microsoft.AspNetCore.Mvc;
using MVC1App.Models;
namespace MVC1App.Controllers
{
    public class SampleController : Controller
    {

        //Controller is a Collection of methods
        public IActionResult Hero()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }

        //normal method
        public dynamic  SI(int n,int p,int r)
        {
            int SI = (p * n * r) / 100;
            return SI;
        }
        //Various return Type of Action Method
        //viewResult only return View
        public ViewResult Information()
        {
            return View();
        }
         //contentResult --if we display set if string

        public ContentResult Data()
        {
            return Content("<h1>Lunch Break!!!","text/html");
        }


        //return As Json

        public JsonResult Person()
        {
            Person person = new Person();

            person.Name = "sai";
            person.city = "Chennai";
            return Json(person);
        }

        public IActionResult GetInfo()
        {
            Person person = new Person();

            person.Name = "sai";
            person.city = "Chennai";
            return Json(person);

            //return Content("<h1>Luch break</h1>");
            //return View();

        }

    }
}
