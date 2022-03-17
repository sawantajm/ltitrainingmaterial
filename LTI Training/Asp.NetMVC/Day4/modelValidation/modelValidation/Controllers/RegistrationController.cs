using Microsoft.AspNetCore.Mvc;
using modelValidation.Models.Mymodel;
namespace modelValidation.Controllers
{
    public class RegistrationController : Controller
    {

        [HttpGet]
        public IActionResult Register()
        {


            return View();
        }
        [HttpPost]

        public IActionResult Register(Registration registration)
        {
            if(ModelState.IsValid)
            {
               
            }
            return View();
        }
    }
}
