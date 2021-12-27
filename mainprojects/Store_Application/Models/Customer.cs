using System;

namespace Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Customer() { }

        public Customer(string userName, string userPW)
        {
            this.username = userName;
            this.password = userPW;
        }

        public Customer(int customerId, string firstName, string lastName, string userName, string email, string userPW)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = userName;
            this.email = email;
            this.password = userPW;
        }


    }
}