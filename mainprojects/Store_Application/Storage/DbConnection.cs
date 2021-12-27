using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace Storage
{
    public class DbConnection
    {
        string dbSource = "Data source = DANIELSPILLERSH\\SQLEXPRESS; initial Catalog = Project_0; integrated security = true";
        private readonly SqlConnection connection;
        private readonly IMapper mapper;

        public DbConnection()
        {
            this.connection = new SqlConnection(dbSource);
            connection.Open();
            this.mapper = new Mapper();
        }

        public void GetCustomer(string userName, string userPW)
        {
            string query = $"SELECT * FROM Customer WHERE UserName = '{userName}' AND Password = '{userPW}' ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();            
            while (dr.Read())
            {
                Console.WriteLine($"Welcome Back, " + dr[1].ToString() + " " + dr[2].ToString());
            }                
        }



        public string GetPastPurchases(string userName, string userPW)
        {
            string query = $"SELECT * FROM Purchases WHERE UserName = {userName} AND WHERE Password = {userPW}";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dr = command.ExecuteReader();
            return dr[0].ToString();
        }

        public void ViewStoreLocations()
        {
            string query = $"SELECT * FROM Location";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }
            connection.Close();
        }

        public void ViewProducts()
        {
            string query = $"SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + "- " + dr[2].ToString() + ": " + dr[3].ToString());
            }
            connection.Close();
        }

        public void AddCustomer(int customerId, string firstName, string lastName, string userName, string email, string userPW)
        {           
           string query = $"INSERT INTO Customer(CustomerId, FirstName, LastName, UserName, Email, Password) VALUES('{customerId}', '{firstName}', '{lastName}', '{userName}', '{email}', '{userPW}')";
            using (SqlCommand command = new SqlCommand(query, connection))
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
