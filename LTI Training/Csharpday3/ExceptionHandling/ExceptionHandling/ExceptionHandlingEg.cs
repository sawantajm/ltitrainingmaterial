using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    class AgeNotValid:ApplicationException
    {
        public AgeNotValid(String message):base(message)
        {

        }
    }

    class ApplyVoterId
    {
        string status;

        public string VoterId(int age)
        {
            if(age>18)
            {
                status = "Eligible for Voter Id";


            }
           

            else
            {
                throw new AgeNotValid("Age shoul be greate than 18 to apply voter Id");
            }
            return status;
        }
    }







    internal class ExceptionHandlingEg
    {
        static void Main()
        {
            float salary;
           float perdaysalary;
            string[] chooselocation = { "Chennai", "Banglore", "Mumbai" };
            ApplyVoterId applyVoterID = new ApplyVoterId();
            try
            {
                Console.WriteLine("Enter your salary per month");
                salary = float.Parse(Console.ReadLine());
                perdaysalary = salary / 30;
               // perdaysalary = float.Parse(Console.ReadLine());
                Console.WriteLine("perdaySalary: {0}",perdaysalary);
                //Console.WriteLine(chooselocation[3]);
                applyVoterID.VoterId(16);
            
            }


            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Please choose the Correct Index!!");


            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
