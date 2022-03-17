using Microsoft.AspNetCore.Mvc;
using MVCDAY1App2.Models;
namespace MVCDAY1App2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Displaydata()
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee {eid=101,ename="sai",salary=50000 });
            employee.Add(new Employee { eid = 102, ename = "Ram", salary = 40000 });
            return View(employee);
        }
    }
}
