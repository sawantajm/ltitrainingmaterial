using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personDetails
{
    internal class Organization
    { //properties
        public String organizationname { get; set; }

        //read -only property
        public int orgid { get; private set; }//get is public and set is a private

        //read -only property
        public string registrationno { get; }

        string[] organizationlocation = { "Mumbai", "Pune", "Chennai" }; //Array


        internal Organization()
        {
            Console.WriteLine("I AM a Default Constructor");

        }
        internal Organization(string orgname)
        {
            orgid = 1001;
            organizationname = orgname;
            registrationno = "org99";


        }
        internal void Display()
        {
            Console.WriteLine("orgid:{0} || orgname:{1} || registrationno:{2}", orgid, organizationname, registrationno);
            foreach (string loc in organizationlocation)
            {
                Console.WriteLine(loc);
            }
        }
    }

    class CompanyInfo
    {

        static void Main()
        {
            Organization organization = new Organization();
            organization.organizationname = "LTI";
            Console.WriteLine("Calling by object 1");
            organization.Display();

            Console.WriteLine("Calling by object @");
            Organization organization1 = new Organization("ABC");

            organization1.Display();

            Console.ReadLine();
        }
    
}
}
