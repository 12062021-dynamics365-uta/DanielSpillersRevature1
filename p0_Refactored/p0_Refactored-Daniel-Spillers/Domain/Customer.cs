using System;

namespace Domain
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string eMail { get; set; }
        public string userPW { get; set; }

        public Customer() { }

        public Customer(int customerId, string firstName, string lastName, string userName, string eMail, string userPW) 
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.eMail = eMail;
            this.userPW = userPW;
        }


    }
}
