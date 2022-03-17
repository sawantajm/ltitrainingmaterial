/*Create an console application to book train tickets.
 * Create a Passenger class with (Name, Age) and write a function called TicketBooking(no_of_tickets) that takes no.of tickets to be booked. 
 * If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". 
 * Else Print  "Ticket Booked Successfully".
 * Add a Test class to call TicketBooking method by accepting all required details.
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpday3Assignment
{


    public class Passenger
    {
        public string Name { get; set; }
        public int age { get; set; }

        internal void printData()
        {
            Console.WriteLine("Enter Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
        }
        internal void TickeBooking(int no_of_ticket)
        {
           
                

               
           


                    if (no_of_ticket > 2)
                    {
                        try
                        {
                            Console.WriteLine("Cannot Book more Than  2 Ticket");
                        }
                        catch(UnauthorizedAccessException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                        Console.WriteLine("Ticket book SuccessFully");
            

          
            
           
        }

    }
    }
    internal class Test
    {
    static void Main()
    {

        Csharpday3Assignment.Passenger passenger = new Csharpday3Assignment.Passenger();

        passenger.printData();
        Console.WriteLine("Enter no of Ticket");
        int n = Convert.ToInt32(Console.ReadLine());
        passenger.TickeBooking(n);
       

    }
 }

