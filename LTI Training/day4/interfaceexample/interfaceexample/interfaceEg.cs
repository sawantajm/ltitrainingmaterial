using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceexample
{
    interface calculator
    {
        string calculatorname { get; set; }

        int Add(int x, int y);
        int sub(int x, int y);

    }

    class normalCaculator : calculator
    {
        public string calculatorname { get; set; }

        int calculator.Add(int a, int b)
        {

            calculatorname = "normal calculator";
            Console.WriteLine(calculatorname);
            return a + b;
        }
        int calculator.sub(int x, int y)
        {
            return x - y; ;
        }



    }
    class InterfaceEg
    {
        static void Main()
        {
            calculator normalcal = new normalCaculator();
            int c = normalcal.Add(9,8);
            Console.WriteLine("Addition Is{0}",c);
        }
    }
}
