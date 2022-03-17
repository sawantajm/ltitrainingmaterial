using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFun
{


    class Mobile
    {
            public string isbn{ get; set; }
         public virtual void Clock()
        {
            Console.WriteLine("I am A Genral Clock ");
        }

        public virtual void eyeSenser()
        {
            Console.WriteLine("I am eye Sensor method of class");
        }
    }
    class Samsung:Mobile
    {
        public override void Clock()
        {
            Console.WriteLine("I am A Samsung Cloack");
        }

        public string  SamsungPay()
        {
            return "Amount";
        }
    }
    internal class VirtualEgcs
    {
       static void Main()
        {
            Mobile mobile = new Mobile();
            mobile.Clock();
            mobile.eyeSenser();

            Samsung samsung = new Samsung();
            Console.WriteLine(samsung.SamsungPay());
        }
    }
}
