using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p0_Daniel
{
    internal class Mapper
    {
        internal List<Customer> EntityToCustomer(SqlDataReader dr)
        {
            List<Customer> customers = new List<Customer>();
            while (dr.Read())
            {
                Customer c = new Customer()
                {
                    customerId = Convert.ToInt32(dr[0].ToString()),
                    firstName = dr[1].ToString(),
                    lastName = dr[2].ToString(),
                    username = dr[3].ToString(),
                    eMail = dr[4].ToString(),
                    password = dr[5].ToString(),
                };
                customers.Add(c);
            }
            return customers;
        }

        internal List<Product> EntityToProductList(SqlDataReader dr)
        {
            List<Product> products = new List<Product>();
            while (dr.Read())
            {
                Product p = new Product()
                {
                    productId = Convert.ToInt32(dr[0].ToString()),
                    productName = dr[1].ToString(),
                    description = dr[2].ToString(),
                    price = Convert.ToDouble(dr[0].ToString()),
                };
                products.Add(p);
            }
            return products;
        }

        internal List<Order> EntityToOrder(SqlDataReader dr)
        {
            List<Order> orders = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order()
                {
                    productId = Convert.ToInt32(dr[0].ToString()),
                    productName = dr[1].ToString(),
                    description = dr[2].ToString(),
                    price = Convert.ToDouble(dr[3].ToString()),
                };
                orders.Add(o);
            }
            return orders;
        }

        internal List<Order> EntityToPastPurchases(SqlDataReader dr)
        {
            List<Order> orders = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order()
                {
                    productId = Convert.ToInt32(dr[0].ToString()),
                    productName = dr[1].ToString(),
                    description = dr[2].ToString(),
                    price = Convert.ToDouble(dr[3].ToString()),
                };
                orders.Add(o);
            }
            return orders;
        }
    }
}