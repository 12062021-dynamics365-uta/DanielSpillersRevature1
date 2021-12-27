using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0_Store_Application
{
    public class Customer
    {
        CustomerList testCustomer;

        public Customer()
        {
            testCustomer = new CustomerList()
            {
                firstName = "Daniel",
                lastName = "Spillers",
                userName = "Dspill88",
                password = "11231988",

            };
        }

        public void ListCustomers()
        {
            List<CustomerList> customers = new List<CustomerList>();

            customers.Add(testCustomer);

            foreach (var customer in customers)
            {
                Console.WriteLine(
                    $"{customer.firstName} {customer.lastName}\n " +
                    $"{customer.userName}: {customer.password}\n");
            }
        }
    }

}
    public class CustomerList
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

    }


