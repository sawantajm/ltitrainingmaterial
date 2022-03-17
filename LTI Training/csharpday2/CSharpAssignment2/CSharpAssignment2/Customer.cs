using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{

    internal class Customer
    {
        public int Customerid { get; set; }
        public  string Name { get; set; }
        public int age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        internal Customer()
        {
            Console.WriteLine("Enter Customer Id");
            Customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customr Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter City");
            City=Console.ReadLine();

        }

        public Customer(int customerid, string name, int age, string phone, string city)
        {
           this.Customerid = customerid;
            this.Name = name;
            this.age = age;
            this.Phone = phone;
            this.City = city;
        }

         internal void DisplayCustomer()
        {
            Console.WriteLine("Customer Id {0} || Name:{1} ||  Age {2} Phone Number: {3} ||  City {4}||",Customerid,Name,age,Phone,City);
        }
    } 

    class Customerinfo
    {
        static void Main()
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer(101,"Ajay",20,"7756953384","Aurangabd");
            customer.DisplayCustomer();
            customer1.DisplayCustomer();
        }
    }



}
