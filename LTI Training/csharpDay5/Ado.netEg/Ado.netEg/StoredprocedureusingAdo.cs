using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Ado.netEg
{
    
    class DAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=AJ-PC\\SQLEXPRESS;Initial Catalog=Northwind; Integrated Security = true");
            con.Open();
            return con;
        }

        //Procedure Without Parameter

       internal void TenProductProcedure()
        {
            try
            {
                con = GetConnection();
                SqlDataReader dr;
                cmd = new SqlCommand("Ten Most Expensive Products", con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]+"  "+dr[1]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                con.Close();
            }
        }

        //Procedure With parameter
        internal void CustomerProcedure(string cid)
        {
            try
            {
                con = GetConnection();
               
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID",cid);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr[0]+" "+dr[1]+ " "+ dr[2] );
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
    internal class StoredprocedureusingAdo
    {

        static void Main()
        {
            DAO dao = new DAO();
            dao.TenProductProcedure();
            Console.WriteLine("Enter Customer ID");
            string cusid = Console.ReadLine();
            dao.CustomerProcedure(cusid);
        }
    }
}
