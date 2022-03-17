using Microsoft.AspNetCore.Mvc;

namespace ex2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            TempData["WelcomeMessage"] = "GoodMorning";
            return RedirectToAction("Greetings", "Sample");
        }



        //FirstRequest
        public IActionResult One_Displayfruit()
        {
            List<string> Furits = new List<string> { "Mango", "orange", "Apple" };
            TempData["MyFruit"] = Furits;
            TempData.Keep();   //remain data in Subsequent reque
            return View();

        }
        //SeconRequest
        public IActionResult Two()
        {
            var getfruit = TempData["MyFruit"];
            return View(getfruit);
        }
    }


}
