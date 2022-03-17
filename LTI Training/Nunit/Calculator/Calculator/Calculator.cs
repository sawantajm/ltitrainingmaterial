using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public int Addition(dynamic a,dynamic b)
        {
            return a + b;
        }

        public int subtaction(dynamic a,dynamic b)
        {
          //if (a < b)
             //   throw new ArgumentException(" first Value Is Less than Second Value");
            if (a < 0)
            {
                throw new ArgumentException("the no is negative");
            }
            return a - b;
        }
    }
}
