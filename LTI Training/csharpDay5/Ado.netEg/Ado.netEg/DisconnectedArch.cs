using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ado.netEg
{

    class DataAcces
    {
        SqlConnection con;
        SqlCommand cmd;
       public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=AJ-PC\\SQLEXPRESS;Initial Catalog=Northwind; Integrated Security = true");
            con.Open();
            return con;

        }
        public void DisplayRegion()
        {
            con = GetConnection();
            SqlDataAdapter da;
           
            da = new SqlDataAdapter("select * from  Region",con);
            DataSet ds = new DataSet();
            da.Fill(ds,"MYRegion");
            //Read table From Dataset
            DataTable dt;
            dt = ds.Tables["MyRegion"];
            foreach( DataRow  row in dt.Rows)
            {
                foreach(DataColumn col in dt.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");

                }
                Console.WriteLine("  ");
            }
            
        /*
            Console.WriteLine("________________________________________--");
            da = new SqlDataAdapter("select * from Shippers",con);
            da.Fill(ds,"MYShippers");
            DataTable dt1;
            dt1 = ds.Tables["MyShippers"];
            foreach(DataRow row in dt1.Rows)
            {
                foreach(DataColumn col in dt1.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");

                }
                Console.WriteLine(" ");
            }
        */
            //Insert new table in Dataset
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Fill(ds);
            //insertion or add new row to region table
            //creating a new rowin myregion table in dataset
            DataRow row1 = ds.Tables["MyRegion"].NewRow();
            Console.WriteLine("Insert data in Region Table");
            row1["RegionID"] = Convert.ToInt32(Console.ReadLine()); 
             
            row1["RegionDescription"] = Console.ReadLine();
            //Adding Row to datatable in dataset
            ds.Tables["MyRegion"].Rows.Add(row1);
            da.Update(ds,"MyRegion");

            Console.WriteLine("____________________");
            dt = ds.Tables["Myregion"];
            foreach(DataRow row in dt.Rows)
            {
                foreach(DataColumn col in dt.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

        } 



    }
    internal class DisconnectedArch
    {
        static void Main()
        {
            DataAcces dataAcces = new DataAcces();
            dataAcces.DisplayRegion();
        }
    }
}
