using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CollectionEg
    {
        static void ArrayListEg()
        {
            ArrayList al = new ArrayList();
            al.Add("Mango");//Boxing
            al.Add("10");
            al.Add("j");
            al.Add(50.0f);
            al.Add(true);

            Console.WriteLine("Capacity Of arraylist", al.Capacity);
            Console.WriteLine("Count{0}",al.Count);
            Console.WriteLine("Index Of Element",al.IndexOf(50.0f));

            //Using for loop
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }

            //Using For Each LOOp
            foreach(var Arralist in al)//Unboxing
            {
                Console.WriteLine(Arralist);
            }
        }


        //Hashtable Contains the Kay Pair Value
        static void HashtableEG()
        {
            Hashtable ht = new Hashtable();
            ht.Add(5,"Mango");
            ht.Add(4,"Apple");
            ht.Add(2,"Graps");
            ht.Add("B","Banana");

            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+ "  " +de.Value);
            }
            Console.WriteLine(ht.Contains("e")); //Showing letter Stating With E
        }

        static void sortedList()
        {
            SortedList sl = new SortedList();

            sl.Add(5, "Mango");
            sl.Add(4, "Apple");
            sl.Add(2, "Graps");
            sl.Add(3, "Banana");
            sl.Add(4,"mago1");


            foreach(DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }


        static void QueueEg()
        {
            Queue queue = new Queue();
            queue.Enqueue("one");
            queue.Enqueue("Two");
            queue.Enqueue("three");
            
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("After Deleting");
            queue.Dequeue();
            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }
        }


        static void  stackfg()
        {
            Stack st = new Stack();
            st.Push(30);
            st.Push("god");
            st.Push(78.23f);
            

            Console.WriteLine("Stack Element");
            Console.WriteLine(st.Pop()); //remove Element From Stack

            foreach(var stack in st)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("Current Element In Statck",st.Peek());//Display  The Current Element In statck



        }



        static void Main()
        {
            ArrayListEg();
            HashtableEG();
            Console.WriteLine("Sorted List");
            sortedList();
            stackfg();
            Console.WriteLine("Queue Example");
            QueueEg();
        }
    }
}
