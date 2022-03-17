using Microsoft.AspNetCore.Mvc;
using modelValidation.Models.Mymodel;
namespace modelValidation.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddBook(Book book)
        {

            return View();
        }
    }
}
