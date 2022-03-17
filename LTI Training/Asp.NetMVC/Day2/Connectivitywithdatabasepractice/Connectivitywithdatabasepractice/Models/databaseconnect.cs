using System.Data.SqlClient;



namespace Connectivitywithdatabasepractice.Models
{


    internal class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public long Phone { get; set; }

   public void  Connection()
        {

            SqlConnection con = null;
            SqlCommand cmd = null;

            con = new SqlConnection("Data Source=\\AJ-PC\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true");


            con.Open();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from Shippers", con);
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0]+" " +dr[1] +" "+dr[2]);
            }



        }
    
    }





    public class databaseconnect
    {
    }
}
