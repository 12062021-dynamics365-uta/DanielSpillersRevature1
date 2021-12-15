using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0_Store_Application
{
    internal class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        protected string paymentMethod { get; set; }

        public List<string> orderHistory { get; set; }

        public Customer(
            string firstName, 
            string lastName, 
            string userName, 
            string password, 
            string paymentMethod
            )

            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.userName = userName;
                this.password = password;
                this.paymentMethod = paymentMethod;
            }


    }
}
