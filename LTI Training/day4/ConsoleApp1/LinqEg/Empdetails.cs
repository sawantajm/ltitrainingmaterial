using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{

    class Employee
    {
        public int id { get; set; }

        public string  name { get; set;}
        public string gender { get; set; }
        public int age { get; set; }
        public string city { get; set; }
       
        public Employee(int id,string name,int age,string gender,string city)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.city = city;

        }
    }
    internal class Empdetails
    {
        static void Main()
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee(1, "gaya", 23, "female", "Chennai"));
            emp.Add(new Employee(2,"ram",24,"Male","Banglore"));
            emp.Add(new Employee(3,"Sri",24,"Male","Chennai"));
            emp.Add(new Employee(4,"Lavanya",28,"female","Madurai"));
            emp.Add(new Employee(5,"Hari",25,"Male","salem"));


            //Display Employee from Chennai

            var emp1 = from e in emp
                       where e.city.Equals("Chennai")
                       select e;
            Console.WriteLine("Dislay Employee From Chennai");
            foreach(Employee employee in emp1)
            {
                Console.WriteLine(employee.id+" "+employee.name+" "+employee.age+ " "+employee.gender);
            }

            //Display name And City
            var emp2 = from e in emp
                       where e.city.Equals("chennai")
                       select new { empname = e.name, empcity = e.city };
            Console.WriteLine("Display Employee Name And City");
            foreach(var e in emp2)
            {
                Console.WriteLine(e.empname+ " "+ e.empcity);
            }

            //Display Employee Details  order by Gender
            var emp3 = from e in emp
                       where e.age > 23
                       orderby e.gender, e.name
                       select e;

            Console.WriteLine("Display Employee details Order by Employee name and gender");

            foreach(var e in emp3)
            {
                Console.WriteLine(e.id+" "+ e.name+" "+ e.gender);
            }

            //Group by 
            //no of mail and femail

            var gendercount = from e in emp
                              group e by e.gender;
            Console.WriteLine("no of males and female");
            foreach(var e in gendercount)
            {
                Console.WriteLine(e.Key+ " "+e.Count());
            }

            //using Ienumrable



            var resu = emp.GroupBy(emp => emp.gender);
            foreach (var g in resu) 
            {
                Console.WriteLine(g);
            }

        }
    }
}
