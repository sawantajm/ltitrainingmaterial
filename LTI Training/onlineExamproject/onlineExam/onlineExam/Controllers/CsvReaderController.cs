using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using onlineExam.Models;
using System.Globalization;

namespace onlineExam.Controllers
{
    [ApiController]
    [Route("CsvReader")]
    public class CsvReaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}



