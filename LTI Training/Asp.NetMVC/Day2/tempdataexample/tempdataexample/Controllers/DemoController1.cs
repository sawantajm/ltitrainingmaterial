using Microsoft.AspNetCore.Mvc;

namespace tempdataexample.Controllers
{
    public class DemoController1 : Controller
    {           
        //temdata dictionary --trancefer data from one action method to another action method same action controller and also diffrent
       //helps data to change subsequent
        public IActionResult Index()
        {
            TempData["WelcomeMessage"]="Goodmorning";
                               //Action Method Name //ControllerName 
            return RedirectToAction("Greetings", "Sample");
        }
    }
}
