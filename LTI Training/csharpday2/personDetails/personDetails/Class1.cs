using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personDetails
{
    //Default Access Specifire  for Avriable is Internal
    class Person
    {
        //variable --Default access Specifire for variable and method is Private
        //Instatnce

        String name, city;

        int age;
        //method or function

        /*Access specifire or modifire return type methodname(paralist)
         {

          }
         */
        void GetData()
        {
            Console.WriteLine("Enter your Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your city");
            city = Console.ReadLine()
;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
        
        }

        void PrintData()
        {
            Console.WriteLine("Name:{0} || City:{1},|| Age :{3}",name,city,age);
        }

        static void Main()
        {
            Person person = new Person();
            person.city="Pune";
            person.GetData();
            person.PrintData();
            Console.ReadLine();
        }
    }

}
