using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personDetails
{
    internal class Student
    {
        public  string sname { get; set; }

        public string dept { get;  set; }

        //static variable

        internal static string collegename;

        //Declare static constructure

        static Student()
        {
            Console.WriteLine("Static Constructor");

            collegename = "MIT";

        }

        public Student(string sname, string dept)
        {
            Console.WriteLine(" Constructor ");
            //this refers to current class intance variable
            this.sname = sname;
            this.dept = dept;
        }   
        internal void PrintData()
        {
            Console.WriteLine("Name:  {0} || Dept:   {1} || College Name:  {2}",sname,dept,collegename);

            
        }
        internal static float StudentAverage(int total, int noofsub)
        {
            int avg = total / noofsub;

            return avg;

        }


        
    }
    class SudentEg
    {
       
        
      public static void Main()
        {
            /*Student student1 = new Student(studname,studdept);
           student.PrintData();
            Student student1 = new Student("Banu","IT");
            student1.PrintData();

            Student student2 = new Student("Srini","Mech");
            student2.PrintData();
            */
           Student.StudentAverage(500, 5);

            //Array of Objet

            
            Console.WriteLine("Enter How Many Student Details");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            string studname, studept;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Name");
                studname = Console.ReadLine();
                Console.WriteLine("Enter Dept");
                studept = Console.ReadLine();
                student[i] = new Student(studname,studept);
            }

            for(int i=0; i<n;i++)
            {    
                student[i].PrintData();
            }
            Console.Read();

        }
    }
}
