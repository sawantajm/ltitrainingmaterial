using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[[Category]]")]

    [ApiController]
   
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;

        public CategoryController(NorthwindContext context)
        {
            db = context;
        }

        //Display All Record 
        #region Display
        [HttpGet]
        public IActionResult Get()
            
        {
            var cat = db.Categories.ToList();
            if(cat!=null)
            {
                return Ok(cat);
            }
            return NotFound("data not found");
        }
        #endregion
        //Add Record 
        #region Insert  Record 
        [HttpPost]

      
        public IActionResult Addcategory(Category category)
        {
            try
            {
                if(category==null)
                {
                    return BadRequest("Category is null");
                }

                else
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                    return Ok("Record Added!!");
                }
            }
            catch (Exception e)
            {
                return Ok("Try after Some times");
            }
        }
        #endregion
        //delete Record 
        #region Delete
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try 
            { 
                var cat = db.Categories.Find(id);

                if(cat!=null)
                {
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                    return Ok("record Deleted");
                }
                else
                {
                    return BadRequest("Record Not Found");
                }
            
            }catch(Exception e)
            {
                    return Ok("Something Went Wrong");
            }
           
        }
#endregion
        //Edit record 
        #region Edit 
        [HttpPut]
        public IActionResult update(int? id, [FromBody] Category category)
        {
            try
            {

                if (id != category.CategoryId)
                {
                    return BadRequest("Record Not Found");
                }
                else
                {
                    db.Entry(category).State = EntityState.Modified;
                    db.SaveChanges();
                    return Ok("record Updated!!");
                
               
                }
            }catch(Exception e)
            {
                return BadRequest("Something Went Wrong");
            }
        }
        #endregion

        //select By id
        #region Record Displayby id 
        [HttpGet("{id}")]
        public IActionResult editcategoryby(int id)
        {
            try
            {
                Category cat = db.Categories.Find(id);

                if(cat==null)
                {
                    return BadRequest("Record Not Found");
                }
                else
                {
                    return Ok(cat);
                }
            }catch(Exception e)
            {
                return Ok("Try after Some time");
            }
        }
        #endregion
    }
}
