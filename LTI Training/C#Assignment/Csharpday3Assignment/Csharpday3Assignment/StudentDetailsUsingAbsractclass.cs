/*
.Create an Abstract class Student with  Name, 
StudentId,Grade as members and also an abstract method Boolean Ispassed(grade)
which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. 
For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.



*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpday3Assignment
{

    abstract public class Student
    {
        public string Name { get; set; }
        public int Studentid { get; set; }

        public double Grade { get; set; }

        abstract public bool Ispassed(double Grade);

        public void studentde()
        {
            Console.WriteLine("Enter Student Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Student Id");
            Studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Student ID {0}||Stdent Name{1} ||Grade{2}", Studentid, Name,Grade);


        }

    }
    public class Graduate:Student
    {
        
        public override bool Ispassed(double Grade)
        {
           
            
            if (Grade > 80)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
                Console.WriteLine("Failed");
            return false;
        }
       

    }

   internal class UnderGrad:Student
    {
        public override bool Ispassed(double Grade)
        {
            if (Grade > 70)
            {
                Console.WriteLine("passed");
                return true;

            }
            else
                Console.WriteLine("Failed");
            return false;
        }

       
    }
    internal class StudentDetailsUsingAbsractclass
    {


       
        static void Main()
        {
            UnderGrad undergrad = new UnderGrad();
            Console.WriteLine("Enter Udergraduate student Details");
            undergrad.studentde();
            Console.WriteLine("Enter Grade");
           double Grade1 = Convert.ToInt32(Console.ReadLine());
           

            bool ug = undergrad.Ispassed(Grade1);
            Console.WriteLine("Grade is {0}", ug);
            Console.WriteLine("Enetr Graduate Student Details");
            Graduate graduate = new Graduate();
            graduate.studentde();
            Console.WriteLine("Enter Grade");
            double Grade2 = Convert.ToInt32(Console.ReadLine());
          bool gg =graduate.Ispassed(Grade2);
            Console.WriteLine("grade is :{0}",gg);

        }


    }
}
