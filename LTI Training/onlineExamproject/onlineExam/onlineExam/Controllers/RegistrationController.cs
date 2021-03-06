using Microsoft.AspNetCore.Mvc;
using onlineExam.Models;

using System.ComponentModel.DataAnnotations;


namespace onlineExam.Controllers
{
    [ApiController]
    [Route("Registration")]
  
     
    public class RegistrationController : Controller
    {
        
        private readonly OnlineExamContext db;
        
        public RegistrationController(OnlineExamContext context)
        {
            db = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var reg = db.Registrations.ToList();
            try
            {
               
                if (reg != null)
                {
                    return Ok(reg);
                }
                else
                {
                    return BadRequest("Record Not Found");
                }
            }
            catch (Exception e)
            {
                return Ok("");
            }

        }


        [HttpPost]
        public IActionResult InsertRecord(Registration registration)
        {
            try
            {
                 if(registration==null)
                {
                    return BadRequest("Registartion is null");
                }
                else
                {
                  
                    db.Registrations.Add(registration);
                    db.SaveChanges();
                    return Ok("Record Added");
                }
            }catch(Exception e)
            {
                return Ok("Rty After Some TIme");
            }

        }
    }
}
