using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Cricket
    {

        public static void Main()

        {
            Console.WriteLine("0's Run in 5 overs");
            int ball1 = 0;
            Random num = new Random();
            int result1;
            for (int i = 0; i <= 5; i++)
            {
                result1 = 1 + num.Next(1);

                Console.WriteLine(result1);
                ball1 += result1;
            }
            Console.WriteLine("\n The sum of 0s Run are");
            Console.WriteLine(ball1);

            Console.WriteLine("\n 1s Run  in 5 overs");

            int ball2 = 0;
            Random num1 = new Random();
            int result2;
            for (int i = 0; i <= 5; i++)
            {
                result2= 1 + num1.Next(2);
                Console.WriteLine( result2);
                ball2 += result2;
            }
            Console.WriteLine("\n the sum of 1s Run are");

            Console.WriteLine(ball2);



            Console.WriteLine("\n 2s runs in 5 overs ");
            int ball3 = 0;
            Random num2 = new Random();
            int result3;
            for (int i = 1; i <= 5; i++)
            {
               result3= 1 + num2.Next(2);
                Console.WriteLine(result3);
                ball3 += result3;
            }

            Console.WriteLine("\n The sum of 2s Runs are");

            Console.WriteLine(ball3);

            Console.WriteLine("\n 3s in 5 overs ");
            int ball4 = 0;
            Random num3 = new Random();
            int result4;
            for (int i = 1; i <= 5; i++)
            {
                result4 = 1 + num3.Next(2);
                ball4 += result4;
                Console.WriteLine(result4);
            }
            Console.WriteLine("\n The sum of 3s Runs are");

            Console.WriteLine(ball4);


            Console.WriteLine("\n 4s  runs in 5 overs ");
            int ball5 = 0;
            Random num5 = new Random();
            int result5;
            for (int i = 1; i <= 5; i++)
            {
                result5 = 1 + num5.Next(2);
                ball5 += result5;
                Console.WriteLine(result5);
            }
            Console.WriteLine("\n The sum of 4s are");

            Console.WriteLine(ball5);

            Console.WriteLine("\n 6s  runs in 5 overs ");
            int ball6 = 0;
            Random num6 = new Random();
            int result6;
            for (int i = 1; i <= 5; i++)
            {
                result6 = 1 + num6.Next(2);
                ball6 = result6;
                Console.WriteLine(result6);
            }
            Console.WriteLine("\n The sum of 6s runs are");

            Console.WriteLine(ball6);


            Console.WriteLine("Total score of that batsman");
            int total = ball2 * 1 + ball3 * 2 + ball4 * 3 + ball5 * 4 + ball6 * 6;

            Console.WriteLine(total);

            Console.WriteLine("\n Strick Rate ");

            int Strick_Rate = (total * 100) / 30;
            Console.WriteLine(Strick_Rate);


        }
    }
}
