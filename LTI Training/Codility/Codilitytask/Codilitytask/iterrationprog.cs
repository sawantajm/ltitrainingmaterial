using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytask
{
    internal class iterrationprog
    {
       static void Example(int n)
        {
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Factorial(int n)
        {

            int factorial = 1;
            for(int i=1;i<n;i++)
            {
                factorial = factorial * i;
                Console.WriteLine(factorial);
            }
            
        }
        static void Tringle(int n)
        {
            for(int i=n;i>0;i--)
            {
                for(int j=i;j<=n;j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
        static void tringle1(int n)
        {
            for(int i=n;i>0;i--)
            {
                for(int j=0;j<(n-1);j++)
                {
                    
                    Console.Write("");
                }
                for (int j = 0; j < (n*2-1); j++)
                {

                   Console.Write("*");
                    
                }
                Console.WriteLine("");
            }
           
        }
        

        static void days()
        {
            string[] days = { "monday", "tuesday", "Wednday" };
            
            for(int i=0;i<days.Length;i++)
            {
                Console.WriteLine(days[i]);
            }
            foreach (var i in days)
            {
                Console.WriteLine(i);
            }
        }

        static void seteg()
        {
            Dictionary<string, string> de = new Dictionary<string, string>();
            de.Add("MON","Monday");
            de.Add("Tue", "Tuesday");
            de.Add("Wed", "Wednday");

            foreach(var i in de)
            {
                Console.WriteLine(i.Key+" stands For "+i.Value);
            }
        }

        //Bin Gap

       static int solution(int N)
        {
            // int[] bin = new int[N];
            
           string Binary = Convert.ToString(N, 2);
          //  Console.WriteLine(Binary);
            int count = 0;
            for(int i=0;i<Binary.Length;i++)
            {


               // Console.WriteLine(Binary[i]);
                if(Binary[i]==1)
                {
                    continue;
                    if(Binary[i]==0)
                    {
                        count = count+1;
                    }
                    Console.WriteLine(count);
                }
               

               
                //Console.Write(Binary[i]);*/
            }
            Console.WriteLine(count);
            return count;
        }

        static void Main()
        {
            //Example(100);
            //Factorial(7);
            //Tringle(5);
            //tringle1(4);
            //days();
            //seteg();
            solution(11);

            

        }

       
           

    }
}
