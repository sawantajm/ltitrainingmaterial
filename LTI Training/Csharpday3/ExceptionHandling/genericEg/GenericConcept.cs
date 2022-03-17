using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericEg
{


    class Sample<T> //Generic Class 
    {
        public T mark1;
        public T mark2;

        internal void Add<T> (T x,T y)
        {
            if(x.Equals(y))
            {
                Console.WriteLine(x+"" +y);

            }

            else 
            {
                Console.WriteLine("Not Equals");

            }

            
        }
        internal void Test()
        {
            if(mark1 !=null &&  mark2!=null)
            {
                Console.WriteLine(mark1+""+mark2);
            }
        }
    }
    internal class GenericConcept
    {
        static void Main()
        {
            Sample<int> sample = new Sample<int>();
            sample.mark1 = 90;

            Sample<float> sample1= new Sample<float>();

            


        }

    }
}
