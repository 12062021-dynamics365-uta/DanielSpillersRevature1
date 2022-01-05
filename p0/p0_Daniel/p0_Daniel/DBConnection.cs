using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p0_Daniel
{
    public class DbConnection
    {
        string dbSource = "Data source = DANIELSPILLERSH\\SQLEXPRESS; initial Catalog = Project_0; integrated security = true";
        private readonly SqlConnection connection;
        private readonly Mapper mapper;
        private readonly Random _random = new Random();

        public DbConnection()
        {
            this.connection = new SqlConnection(dbSource);
            connection.Open();
            this.mapper = new Mapper();
            this._random = new Random();
        }



        internal List<Customer> GetAllCustomers()
        {
            string query = "SELECT * FROM Customer;";
            List<Customer> customers = new List<Customer>();
            using (SqlCommand cmd = new SqlCommand(query, this.connection))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                customers = this.mapper.EntityToCustomer(dr);
                dr.Close();// make sure this class is Transient... not singleton or Scoped.
            }
            return customers;
        }

        public void AddCustomer(string firstName, string lastName, string userName, string email, string password)
        {
            int Random() {return _random.Next(6, 1000000);}
            int customerId = Random();
            string query = $"INSERT INTO Customer(CustomerId, FirstName, LastName, UserName, Email, Password) VALUES('{customerId}', '{firstName}', '{lastName}', '{userName}', '{email}', '{password}')";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                this.mapper.EntityToCustomer(dr);
                dr.Close();// make sure this class is Transient... not singleton or Scoped.
            }
        }

        internal void OrderToDatabase(int productId, string productName, string productDesc, double price, double total)
        {
            string query = $"INSERT INTO PastPurchases(ProductId, ProductName, ProductDesc, Price, Total) VALUES('{productId}','{productName}','{productDesc}','{price}','{total}')";
            SqlCommand cmd = new SqlCommand(query, this.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();

        }
        


        public List<Customer> GetCustomer(string userName, string password)
        {
            string query = $"SELECT * FROM Customer WHERE UserName = '{userName}' AND Password = '{password}' ";
            List<Customer> customers = new List<Customer>();
            using (SqlCommand cmd = new SqlCommand(query, this.connection))
            {            
                SqlDataReader dr = cmd.ExecuteReader();
                customers = this.mapper.EntityToCustomer(dr);
                this.connection.Close();
                dr.Close();// make sure this class is Transient... not singleton or Scoped.
            }
            return customers;
        }



        public void GetPastPurchases(double totalPast)
        {
            string query = $"SELECT * FROM PastPurchases WHERE Total = {totalPast}";;
            SqlCommand command = new SqlCommand(query, this.connection);
            using (SqlDataReader dr = command.ExecuteReader())
                while (dr.Read())
                {
                    Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + "- " + dr[2].ToString() + ": " + dr[3].ToString() + dr[4].ToString());
                }
        }

        public void ViewProducts()
        {
            string query = $"SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, this.connection);
            using (SqlDataReader dr = command.ExecuteReader())
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + "- " + dr[2].ToString() + ": " + dr[3].ToString());
            } 
        }

        public List<Order> ProductToOrder(int validProduct)
        {
            string query = $"SELECT * FROM Products WHERE ProductId = {validProduct}";
            List<Order> orders = new List<Order>();
            SqlCommand command = new SqlCommand(query, this.connection);
            using (SqlDataReader dr = command.ExecuteReader())    
            orders = this.mapper.EntityToOrder(dr);
  
            return orders;
        }

    }
}