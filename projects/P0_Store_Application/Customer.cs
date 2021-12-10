using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0_Store_Application
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public  Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


    }
}
