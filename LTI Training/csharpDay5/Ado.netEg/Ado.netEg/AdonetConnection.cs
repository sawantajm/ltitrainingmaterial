using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.netEg
{

    class Shippers
    {
        public int shipperid { get; set; }
        public string companyname { get; set; }
        public string phone { get; set; }


        public void GetShipper()
        {
            Console.WriteLine("Enter Shipper Name");
            companyname = Console.ReadLine();
            Console.WriteLine("Enter Shipper Phone Number");
            phone = Console.ReadLine();
        }
    }
    internal class Ado
    {

        static void Main()
        {
            //create Object for Shipper Class
            Shippers shipper = new Shippers();
            //2.create Sql Connection Object
            SqlConnection con = null; 
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection("Data Source=AJ-PC\\SQLEXPRESS;Initial Catalog=Northwind; Integrated Security = true");
                

                //4.open Connection
                con.Open();


                //Call Getshipper Method
                //  shipper.GetShipper();

                //Insert
                
                                cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) values(@cname,@cphone)", con);
                                cmd.Parameters.AddWithValue("@cname",shipper.companyname);
                                cmd.Parameters.AddWithValue("@cphone",shipper.phone);
                                int i = cmd.ExecuteNonQuery();
                                Console.WriteLine("Record inserted is:{0}", i);
                
                //Delete Opration
                Console.WriteLine("Enter the Shipper Name Who have Deleted ");
                shipper.companyname = Console.ReadLine();
                cmd = new SqlCommand("delete from Shippers where CompanyName=@cname",con);
                cmd.Parameters.AddWithValue("@cname",shipper.companyname);
               int i= cmd.ExecuteNonQuery();
                Console.WriteLine("Record is deleted",i);
               

                //select Query
                SqlDataReader dr;
                cmd = new SqlCommand("select * from Shippers",con);
                dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr["Shipperid"]+" "+dr["CompanyName"] + "" + dr["phone"]);
                }
                



                //Update Query
                Console.WriteLine("Enter The Shipper Id whose record you want to updated");
                shipper.shipperid = Convert.ToInt32(Console.ReadLine());
                shipper.GetShipper();
                cmd = new SqlCommand("update Shippers set  CompanyName=@cname,phone=@cphone where ShipperID=@sid", con);
                cmd.Parameters.AddWithValue("@sid",shipper.shipperid);
                cmd.Parameters.AddWithValue("@cname",shipper.companyname);
                cmd.Parameters.AddWithValue("@cphone",shipper.phone);
                int i = cmd.ExecuteNonQuery();
               

                //Scalar value
                cmd = new SqlCommand("select count(ShipperID) from Shippers ",con);
                Console.WriteLine("No of Shippers:{0}",cmd.ExecuteScalar());
               
                cmd = new SqlCommand("select CompanyName from Shippers  where ShipperID=1  ", con);
                Console.WriteLine("Company Name Is{0}",cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                cmd = new SqlCommand("select CompanyName from Shippers Where ShipperID=2",con);
                Console.WriteLine("Company Name is{0}",cmd.ExecuteScalar());




            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
