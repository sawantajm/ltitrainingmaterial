using System;
using System.Linq;

namespace LinqEg
{
    /*
     * 
     * <from range variable> in <Ienumrable<T> or IQuerable <T> collection>
     * standard query or lambda expression
     * <select or group by orrator > <result>
     */

    class LinqUsingobjects
    {
        //datasource

        string[] books = { "Java", "English", "Cloud Computing", "Gride Computing ", "Devops" };
        int[] marks = { 70, 80, 90, 77, 89, 56 };

        internal void StringArry()
        {
            //fetching all the Books

            var result = from bk in books
                         select bk;
            Console.WriteLine("fetching all the Books");
            foreach (var bookname  in result)
            {
                Console.WriteLine(bookname);
            }

            //fetch the book name contain 'Computing'


            var result1 = from b in books
                          where b.Contains("Computing")
                          select b;

            Console.WriteLine("fetch the book name contain 'Computing'");

            foreach (var bookname in result1)
            {
                Console.WriteLine(bookname);
            }


            //Realational oprator ,Aggregate Function 
            Console.WriteLine("Minimum Marks{0}",marks.Min());
            Console.WriteLine("Maximum Marks {0}",marks.Max());

            //Display No of student Between 80 to 90 Marks

            int noofstudent = (from mr in marks
                               where mr > 80 && mr < 90
                               select mr).Count();


            Console.WriteLine("No of student between 80 and 90:{0}",noofstudent);

            //Dispaly the below 80 Marks

            int below80 = (from mr in marks
                           where mr < 80
                           select mr).Count();

            Console.WriteLine("below 80 Marks{0}",below80);
        
        }

         

        
    }
    
    class progam
    {
        static void Main()
        {
            LinqUsingobjects linq = new LinqUsingobjects();
            linq.StringArry();
        }
    }



}
