using Microsoft.AspNetCore.Mvc;

namespace ex2.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }
    }
}
