using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CollectionWithgenerics
    {
        static void ListEG()
        {
            List<String> book = new List<string>();
            book.Add("Java");
            book.Add("OS");
            book.Add("NW");
            book.Add("OOAD");

            
            book.Insert(2,".net");
            foreach (var list in book)
            {
                Console.WriteLine(list);
            }

            List<string> book1 = new List<string>();
            book1.Add("XXXXX");
            book1.Add("YYYYY");

            book.AddRange(book1);// Adding Another one List into List

            Console.WriteLine("After Adding authoer");
            foreach(var listbook in book)
            {
                Console.WriteLine("Book:{0}",listbook);
            }

        }
        static void DictionaryEg()
        {
            Dictionary<int, String> dt = new Dictionary<int, string>();
            dt.Add(1,"Anu");
            dt.Add(2,"Banu");
            dt.Add(3, "Ram");

            Console.WriteLine("___________________Dictionary-_________________");
            foreach (KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key+" "+kp.Value);

            }

        }
        static void sortedlist()
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(3, "Anu");
            st.Add(1, "Banu");
            st.Add(6, "Ram");
            st.Add(7, "sham");


            Console.WriteLine("_________________________Sorted List__________________");
            foreach(KeyValuePair<int,string> kp in st)
            {
                Console.WriteLine(kp.Key+" "+ kp.Value);
            }
        }

        static void Main()
        {
           // ListEG();
           // DictionaryEg();
            sortedlist();
        }

    }
}
