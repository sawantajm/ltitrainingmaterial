using Microsoft.AspNetCore.Mvc;
using MVC1App.Models;
namespace MVC1App.Controllers
{
    public class HRController : Controller
    {
        public IActionResult DisplayPerson()
        {
            Person person = new Person();
            person.Name = "Ajay";
            person.city = "Aurangabad";
          
            return View(person);
        }
        public IActionResult listofPerson()
        {

            List<Person> person = new List<Person>();
            person.Add(new Person { Name = "Ajay", city = "Vaijapur" });
            person.Add(new Person { Name = "Sai", city = "sinner" });
            person.Add(new Person { Name = "Yogi", city = "Saigaon" }); ;
           
            return View(person);
        }

        //ViewData and ViewBag - to Pass data from Controller to view
        //view bag is a Dynamic and view data is a Dictionary
        public IActionResult GetMobile()
        {
            List<string> mobilename = new List<string>() { "samsung","oppo","one+"};

            ViewData["Datamobile"] = mobilename;
            ViewBag.bagmobile = mobilename;
            return View();
        }
    }
}
