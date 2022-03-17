using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg
{


    abstract class RBI
    {
        public int noofbanksundercontrol { get; set; }
        abstract public int HomeLoan();

        internal string Rules()
        {
            return "Pan Card Is Mandatory for All Customers";
        }
    }


    class SBI : RBI
    {
        public override int HomeLoan()
        {
            Console.WriteLine("Mandatory Document for Homeloan: Adhar Card , salary slip");
            return 9;
        }
    }

    class ICICI : RBI
    {
        public override int HomeLoan()
        {
            Console.WriteLine("ICICI Home Loan percentage:");

            return 10;
        }
    }
    internal class AbstractEg
    {
        static void Main()
        {
            /* SBI sbiobj = new SBI();
             Console.WriteLine(sbiobj.Rules());
             Console.WriteLine(sbiobj.HomeLoan());



             ICICI icici = new ICICI();
             Console.WriteLine(icici.HomeLoan());
             */


            //Run time Ploymorphism mean Mehod OverRiding
            RBI robj;
            robj = new SBI();
            robj.Rules();
            Console.WriteLine(robj.HomeLoan());
            robj = new ICICI();
            Console.WriteLine(robj.HomeLoan());


        }
        

        
        
        
    }
}
