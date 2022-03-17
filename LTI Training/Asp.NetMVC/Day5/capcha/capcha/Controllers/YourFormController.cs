using Microsoft.AspNetCore.Mvc;

namespace capcha.Controllers
{
    public class YourFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
