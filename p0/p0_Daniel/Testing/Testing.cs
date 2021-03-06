using System;
using Xunit;
using p0_Daniel;
using System.Collections.Generic;


namespace Testing
{
    public class Testing
    {
        [Fact]
        public void Test1()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Customer> customers = connect.GetCustomer();

            Assert.Equal(3, customers.Count);
        }
        [Fact]
        public void Test2()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Customer> customers = connect.GetCustomer();

            Assert.NotNull(connect);
        }
        [Fact]
        public void Test3()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Product> products = connect.GetProducts();

            Assert.Equal(3, products.Count);
        }
        [Fact]
        public void Test4()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Product> products = connect.GetProducts();

            Assert.NotNull(connect);
        }
        [Fact]
        public void Test5()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Order> orders = connect.GetOrders();

            Assert.Equal(3, orders.Count);
        }
        [Fact]
        public void Test6()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Order> orders = connect.GetOrders();

            Assert.NotNull(connect);
        }
        [Fact]
        public void Test7()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Customer> customers = connect.GetCustomer();

            Customer c4 = new Customer()
            {
                customerId = 4,
                firstName = "D",
                lastName = "pill",
                username = "DnS",
                eMail = "danthem@co.com",
                password = "1111345",
            };
            customers.Add(c4);

            Assert.Equal(4, customers.Count);
        }
        [Fact]
        public void Test8()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Product> products = connect.GetProducts();

            Product p4 = new Product()
            {
                productId = 3,
                productName = "added",
                description = "new thing",
                price = 213.00
            };
            products.Add(p4);

            Assert.Equal(4, products.Count);
        }
        [Fact]
        public void Test9()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Order> orders = connect.GetOrders();
            Order o4 = new Order()
            {
                productId = 101,
                productName = "bing bong",
                description = "knickstape",
                price = 199.00
            };
            orders.Add(o4);

            Assert.Equal(4, orders.Count);
        }
        [Fact]
        public void Test10()
        {
            MockDbConnection connect = new MockDbConnection();
            List<Customer> customers = connect.GetCustomer();

            Assert.IsType<Customer>(customers[0]);
        }
    }
}
