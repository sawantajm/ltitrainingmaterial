using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEmployee
{


    public class EmployeeDetails
    {
        public int id { get; set; }
        public string Name { get; set; }

        public double salary { get; set; }
        public string Gender { get; set; }
    }
    public  class Logic
    {
        #region Login
        public string Login(string UserId, string password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(password))
            {
                return "Userid or password cant be null!!";

            }
            else
            {
                if (UserId == "Admin" && password == "Admin")
                {
                    return "Welcome";
                }
                else
                {
                    return "Incorrect password";
                }
            }
        }
        #endregion
        #region
        public List<EmployeeDetails> Alluser()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { id = 101, Name = "sai", Gender = "Male", salary = 34000 });

            li.Add(new EmployeeDetails { id = 102, Name = "Nisha", Gender = "Female", salary = 34000 });
            li.Add(new EmployeeDetails { id = 103, Name = "ram", Gender = "Male", salary = 50000 });
            li.Add(new EmployeeDetails { id = 104, Name = "Kumar", Gender = "Male", salary = 74000 });
            return li;
        }
        #endregion



        public List<EmployeeDetails> GetDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            Logic logic = new Logic();
            var liuser = logic.Alluser();
            foreach (var x in liuser)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }

   public class empdetails
{
         static void Main()
        {

        }
    }

}
