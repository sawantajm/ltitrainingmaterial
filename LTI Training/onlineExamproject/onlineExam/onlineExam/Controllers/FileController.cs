using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onlineExam.Models;
using System.Net;
using System.Text;



namespace onlineExam.Controllers
{
    [ApiController]
    [Route("FileReader")]
    public class FileController : Controller
    {
        private readonly OnlineExamContext db;

        public FileController(OnlineExamContext context)
        {
            db = context;
        }
        [HttpGet]

        public IActionResult GetFile()
        {
            var file = db.QuestionDetails.ToList();
            if (file == null)
            {
                return BadRequest("FileNot found");
            }
            else
            {
                return Ok(file);
            }




        }



        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }



            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.ToList(), size, filePath });
           



        }

    }

}
