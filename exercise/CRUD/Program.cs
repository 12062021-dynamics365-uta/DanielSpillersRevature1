using System;
using System.Data.SqlClient;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data source =DANIELSPILLERSH\\SQLEXPRESS;initial Catalog=Shinook; integrated security = true");
            string queryString = "Select * from Artist";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString());
            }
            connection.Close();
        }
    }
}
