using Microsoft.AspNetCore.Mvc;
using tryfilereading.Models;
namespace tryfilereading.Controllers
{
    public class fileController : Controller
    {
        [HttpGet]
        public IActionResult FileRead()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FileRead(fileupload file)
        {

            return View();
        }
       
    }
}
