using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{


    public class Vehical
    {
        protected string regnumber { get; set; }
        protected int speed { get; set; }
        protected string color { get; set; }
        protected string Ownername { get; set; }

        public Vehical(string regnumber, int speed, string color, string ownername)
        {
            this.regnumber = regnumber;
            this.speed = speed;
            this.color = color;
            Ownername = ownername;
        }
     }
    class Bus : Vehical
    {
                 private string routnumber;

        public Bus(string regnumber, int speed, string color, string Ownername, string Routnumber) : base(regnumber,speed,color,Ownername)
         {
        
            
            this.routnumber = Routnumber;
         }


        public  void ShowData()
        {
            Console.WriteLine("Bus Information");
            Console.WriteLine("RegNo:{0} || speed: {1} || color :{2} || OwnerName:{3} ||RoutNumber:{4}", regnumber, speed, color, Ownername, routnumber);
        }
    }

    class Car:Vehical
    {
        private string manufactureName;

       public  Car(string regnumber, int speed, string color, string Ownername, string manufactureName):base(regnumber,speed,color,Ownername)
        {
            this.manufactureName = manufactureName;

        }

        internal void ShowData()
        {

            Console.WriteLine("Car Information");
            Console.WriteLine("RegNo:{0} || speed: {1} || color :{2} || OwnerName:{3} || ManufactureName:{4}",regnumber,speed,color,Ownername,manufactureName);
        }
    }



    class vehicalInfo
    {
        static void Main()
        {
            Bus bus = new Bus("MH 20 EG 8172", 50, "Red", "MSRTC", "Pune2");

            bus.ShowData();
            Car car = new Car("MH 40 AC 8888", 20, "Black", "Ajay", "Tesla");
            car.ShowData();
       }
    }
}
