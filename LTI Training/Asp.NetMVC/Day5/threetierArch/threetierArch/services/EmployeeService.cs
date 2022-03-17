using threetierArch.Models;
namespace threetierArch.services
{
    public class EmployeeService
    {
        private readonly NorthwindContext db;

        public EmployeeService(NorthwindContext context)
        {
            db=context;
        }
        public Employees GetEmployeebyidnotasync(int id)
        {
            dynamic e =(from emp in db.Employees
                        where emp.EmployeeId==id
                        select emp.FirstName).FirstOrDefault();
        
        
        
        dynamic emp1=db.Employees where(e=>e.EmployeeId==id).select(n => n.firstname.FirstOrDefault());       
        }


        //Async way
        public async Task<string> GetEmployeebyid(int id)
        {
            dynamic e = (from emp in db.Employees
                         where emp.EmployeeId == id
                         select emp.FirstName).FirstOrDefault();
        }
    }
}
