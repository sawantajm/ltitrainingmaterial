using Microsoft.AspNetCore.Mvc;

namespace tempdataexample.Controllers
{
    public class SampleController1 : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }
    }
}
