using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    [TestFixture]
    internal class Calculatortestcase
    {
        Calculator calculator = new Calculator();

        [TestCase]

        public void Add()
        {
            Assert.AreEqual(40,calculator.Addition(30,10));
        }

        [TestCase]

        public void sub()
        {
            Assert.Catch<ArgumentException>(()=>calculator.subtaction(8,1));
        }
    }
}
