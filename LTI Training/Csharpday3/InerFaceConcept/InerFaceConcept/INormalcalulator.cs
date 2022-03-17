using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InerFaceConcept
{
     interface INormalcalulator
    {

        string calculatorname { get; set; }
        int Add(int a, int b);
        int Sub(int a, int b);
    }
    public class Pixel:INormalCalculator,Iscientificcalculator
    {
        public string isbn { get; set; }

        public string calculatorname { get; set; }
    }


    int INormalcalculator.Add(int x,int y)
    {

    }
    int INormalcalculator.Sub(int x, int y)
    {
        return x - y;
    }
    int Iscientificcalculator.Add(int x, int y)
    {
        calculatorname = "Scientific calculator";
        return x + y;
    }


    class InterfaceEg
    {
        static void Main()
        {
            INormalCalculator1 normalCalculator = new Pixel();
            int c = normalCalculator.Add(9, 8);
        }
    }
}
