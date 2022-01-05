using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storage
{
    public class DatabaseConnection
    {
        string dbSource = "Data source = DANIELSPILLERSH\\SQLEXPRESS; initial Catalog = P0; integrated security = true";
        private readonly SqlConnection connection;

        public DatabaseConnection()
        {
            this.connection = new SqlConnection(dbSource);
            connection.Open();
        }


        public void AddCustomer(string firstName, string lastName, string userName, string eMail, string userPW)
        {
            string query = $"INSERT INTO Customer(FirstName, LastName, UserName, Email, Password) VALUES('{firstName}', '{lastName}', '{userName}', '{eMail}', '{userPW}')";
            using SqlCommand cmd = new SqlCommand(query, this.connection);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
        }

        public int LoginCustomer(string userName, string userPW)
        {
            int foundCustomerId;
            string query = $"SELECT * FROM Customer WHERE UserName = '{userName}' AND Password = '{userPW}' ";
            SqlCommand cmd = new SqlCommand(query, this.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                foundCustomerId = Int32.Parse(dr[0].ToString());
                string customerFirstName = Convert.ToString(dr[1].ToString());
                string customerLastName = Convert.ToString(dr[2].ToString());
                string customerUserName = Convert.ToString(dr[3].ToString());
                string customerEmail = Convert.ToString(dr[4].ToString());
                string customerPassword = Convert.ToString(dr[5].ToString());
            }
            catch
            {
                foundCustomerId = 0;
            }
            connection.Close();
            return foundCustomerId;
        }
    }
}
