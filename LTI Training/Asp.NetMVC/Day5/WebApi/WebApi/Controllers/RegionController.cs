using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("Api/[[region]]")]
    public class RegionController : Controller
    {
        private readonly NorthwindContext db;

        public RegionController(NorthwindContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var reg = db.Regions.ToList();
            if(reg==null)
            {
                return NotFound("data Not found");
            }

            return Ok(reg);
        }

        [HttpPost]

        public IActionResult AddRegion(Region region)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Regions.Add(region);

                    db.SaveChanges();
                    return Ok("Record Added!!");
                    
                }
                else
                {
                    return BadRequest("Region Is Null");
                }

            }catch(Exception )
            {
                return Ok(" Try After Some Time ");
            }
        }
    }
}
