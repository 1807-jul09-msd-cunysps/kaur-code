using System;
using System.Data;// ADO.Net lib
using System.Data.SqlClient;

namespace ADO.NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con=null;
            string command = "select * from Persons";
            string conStr = "Data Source=sabrina-cuny-sps-rev.database.windows.net;Initial Catalog=TestDb;Persist Security Info=True;User ID=sabrinaf;Password=Shona2018!";
            //1. SQL Connection
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                //2. SQL Command
                SqlCommand cmd = new SqlCommand(command,con);
                //3. Execute query
                SqlDataReader dr= cmd.ExecuteReader();
                Console.WriteLine("Id    Name             Date of birth");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]+" "+dr[1]+" "+dr[2]+" "+dr[4]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                con.Close();
            }
        }
    }
}
