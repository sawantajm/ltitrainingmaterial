using Microsoft.AspNetCore.Mvc;
using Layout.Models;
namespace Layout.Controllers
{
    //Attrubute Routing 
    [Route("Cusromer")]
    public class UserController : Controller
    {
        [Route("Register")]
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User user)
        {
            return View();
                
        }

        [Route("id/{id:int?}")]

        public IActionResult userbyid(int id)
        {
            return View();
        }

        [Route("user/{city=Mumbai}")]

        public IActionResult userbycity(string city)
        {
            return View();
        }

        [Route("studentname/{result=pass}")]
        public IActionResult Result(string result)
        {
            return View();
        }
    }
}
