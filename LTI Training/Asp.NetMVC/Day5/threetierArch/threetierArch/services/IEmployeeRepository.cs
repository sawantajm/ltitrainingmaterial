using threetierArch.Models;

namespace threetierArch.services
{
    public interface IEmployeeRepository
    {
       public  Employees GetEmployeebyidnotasync(int id); //normal method
       public  Task<string> GetEmployeebyid(int id);//Async
        void GetEmployeebyid(object id);
    }
}
