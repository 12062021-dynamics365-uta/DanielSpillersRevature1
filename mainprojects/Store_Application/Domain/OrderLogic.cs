using System;
using System.Collections.Generic;
using System.Linq;
using Storage;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderLogic
    {
        List<Customer> customers;       //ALL CUSTOMERS
        List<Order> orders;             //ALL ORDERS
        List<Product> products;         //ALL PRODUCTS
        private Customer currentCustomer;
        DbConnection database = new DbConnection();

        //CONSTRUCTOR
        public OrderLogic()
        {
            customers = new List<Customer>();
            orders = new List<Order>();
            products = new List<Product>();
        }

        public OrderLogic(string userName, string userPW)
        {
            this.customers = new List<Customer>();
            Customer customer = new Customer(userName, userPW);
        }

        public void Login(string userName, string userPW)
        {
            database.GetCustomer(userName, userPW);
            if (userName != null && userPW != null) //ASK MARK FOR HELP ON THIS
            {
                Console.WriteLine($"Welcome Back, {userName}");
            }
            
            //Customer c = customers.Where(c => c.username == userName && c.password == userPW).FirstOrDefault();

            if (userName == null && userPW == null) //ASK MARK FOR HELP ON THIS
            {
                Console.WriteLine("This user is not registered.\nWould you like to register?");
                Console.WriteLine("type register to begin registration");
                string register = Console.ReadLine();

                if(register.ToUpper() == "REGISTER")
                {
                    Console.WriteLine("Please enter your first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter your last name");
                    string lastName = Console.ReadLine();
                    Register(userName, userPW);
                    Console.WriteLine($"Welcome, {firstName}! You are logged in as {userName}");
                } else
                {
                    Console.WriteLine("Incorrect selection, please try again.");
                }


            }
        }

        public void Register(string userName, string userPW)
        {
            Customer cust = new Customer(userName, userPW);
            this.currentCustomer = cust;
            customers.Add(cust);
        }

        public void Register(string firstName, string lastName, string userName, string userPW)
        {
            Customer cust = new Customer(firstName, lastName, userName, userPW);
            this.currentCustomer = cust;
            customers.Add(cust);
        }

        public void SelectStoreLocation(string storeSelection, bool locValSelect, int validLocation)
        {

            if (!locValSelect || validLocation < 1 || validLocation > 4)
            {
                Console.WriteLine("That is not a valid choice. Please choose again");
            }
            else
            {
                Console.WriteLine($"You Chose: " + (Locations)validLocation + ". If that the correct store? Yes or No");
            };
        }



    }
}
