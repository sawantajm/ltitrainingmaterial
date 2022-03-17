using Microsoft.AspNetCore.Mvc;
using threetierArch.services;

namespace threetierArch.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository dbemployeeRepository;
     
      public EmployeeController(IEmployeeRepository employeeRepository)
        {
            dbemployeeRepository = employeeRepository;
        }
        
        [HttpGet("{id}")]
      public async Task<IActionResult> GetEmployeedeatils(int id)
        {
            dynamic employee = await dbemployeeRepository.GetEmployeebyid(id);

            return Ok(employee);
        }
    }
}
