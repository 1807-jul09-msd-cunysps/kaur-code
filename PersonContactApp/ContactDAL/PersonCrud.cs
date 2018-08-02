using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ContactLibrary;

namespace ContactDAL
{
    public class PersonCrud
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string conStr = "Data Source=rev-cuny-sps-server.database.windows.net;Initial Catalog=PhoneDb;User ID=kaur;Password=Password123";
        string cmdStr = "";
        //GetPersons
        public List<Person> GetPersons()
        {
            using (con = new SqlConnection(conStr))
            {
                List<Person> persons = new List<Person>();

                cmdStr = "select * from Person";
                con.Open();
                cmd = new SqlCommand(cmdStr, con);
                try
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Person p = new Person();
                        p.PGuid = dr["PGuid"].ToString();
                        p.Pid = Convert.ToInt32(dr["P_Id"]);
                        p.firstName = dr["firstName"].ToString();
                        p.lastName = dr["lastName"].ToString();
                        p.Age = Convert.ToInt32(dr["Age"]);
                        p.email = dr["email"].ToString();
                        persons.Add(p);
                        p = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dr.Close();
                }
                return persons;
            }
        }
        //GetPersonById
        //Insert
        //Delete
        //update
    }
}
