using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    public class Product
    {       
        public int pid { get; set; }
        
        public string Pname { get; set; }
        public int price { get; set; }
        
        
        static string ShopName;
        static int Shopid;

        

       
        static  Product()
        {
            ShopName = "Samarth Kirana Stor";
            Shopid = 10001;
        }

        public Product(int pid, string pname, int price)
        {
            this.pid = pid;
            Pname = pname;
            this.price = price;
        }

        internal  void Display()
        {

            Console.WriteLine("Shop Id :{0} || ShopName:{1} || ProductID:{2} || ProductName:{3} ||Price:{4}",Shopid,ShopName,pid,Pname,price);
        }

    }
    class productinfo
    {
       
        public static void Main()
        {


             Console.WriteLine("How many product details  ");
            
            int noofproduct = Convert.ToInt32(Console.ReadLine());

            Product[] product = new Product[noofproduct];
            string pname;
            int Price, pid;
            for (int i=0;i<noofproduct;i++)
            {
                Console.WriteLine("Enter product Id:");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name ");
                 pname = Console.ReadLine();
                Console.WriteLine("Enter The Price");
                 Price = Convert.ToInt32(Console.ReadLine());
                product[i] = new Product(pid,pname,Price);
                product[i].Display();
            }



        }
    }
}
