using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Storage
{
    internal class Mapper : IMapper
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
                    email = dr[4].ToString(),
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
                Product p = new Product();
                {
                    productId = Convert.ToInt32(dr[0].ToString());
                    productName = dr[1].ToString();
                    description = dr[2].ToString();
                    price = Convert.ToDouble(dr[0].ToString());
                };
                products.Add(p);
            }
        }

        internal List<Location> EntityToLocation(SqlDataReader dr)
        {
            List<Location> locations = new List<Location>();
            while (dr.Read())
            {
                Location l = new Location();
                {
                    locationId = Convert.ToInt32(dr[0].ToString());
                    locationName = dr[1].ToString();
                };
                locations.Add(l);
            }
        }

        internal List<Order> EntityToOrder(SqlDataReader dr)
        {
            List<Order> order = new List<Order>();
            while(dr.Read())
            {
                Order o = new Order();
                {
                    
                };
                order.Add(o);
            }
        }

    }
}

