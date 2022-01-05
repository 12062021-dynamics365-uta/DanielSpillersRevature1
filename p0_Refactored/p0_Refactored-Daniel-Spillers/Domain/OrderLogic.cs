using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderLogic
    {
        List<Customer> customers;
        List<Products> products;
        private Customer currentCustomer;
        private readonly DatabaseConnection _database;
        DatabaseConnection database = new DatabaseConnection();

        public OrderLogic()
        {
            customers = new List<Customer>();
            products = new List<Products>();
            this._database = database;
        }


        public void Shop()
        {
            bool validChoice = false;
            int choice = -1;
            Console.WriteLine("Welcome to Casa De Con'Sole'.");

            do
            {

                Console.WriteLine("What would you like to do?\n[1] Login\n[2] Register\n[3] Exit");
                string userChoice = Console.ReadLine();
                validChoice = Int32.TryParse(userChoice, out choice);
                if (choice > 3 || choice < 1 || validChoice == false)
                {
                    Console.WriteLine("Sorry, but that is not a selection option. Please Try Again");
                }
                
            } while (choice > 3 || choice < 1 || validChoice == false);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Login();
                    break;
                case 2:
                    Console.Clear();
                    Register();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Thank you for visiting Casa De Con'Sole'");
                    break;
            }


        }

        private List<Customer> Register()
        {
            Customer c1 = new Customer();
            Console.WriteLine("Please Enter your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please Enter your Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please Enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please Enter your E-Mail Address:");
            string eMail = Console.ReadLine();
            Console.WriteLine("Please Enter your Password:");
            string userPW = Console.ReadLine();
            customers.Add(c1);
            database.AddCustomer(firstName, lastName, userName, eMail, userPW);
            return customers;
        }

        private void Login()
        {
            Console.WriteLine("Please Enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please Enter your Password:");
            string userPW = Console.ReadLine();
            int currentCustomer = database.LoginCustomer(userName, userPW);

            if (currentCustomer != 0)
            {
                Console.Clear();
                Console.WriteLine($"Welcome Back, {userName}");
                ShopMenu();
            }
            else if (currentCustomer == 0)
            {
                Console.Clear();
                Console.WriteLine("We did not find a user for the credentials entered. Please continue with Registration or Logout.");
                FailedCredentials(userName, userPW);
            }
        }


        private void FailedCredentials(string userName, string userPW)
        {
            Customer c1 = new Customer();
            Console.WriteLine("Please Enter your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please Enter your Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please Enter your E-Mail Address:");
            string eMail = Console.ReadLine();
            customers.Add(c1);
            database.AddCustomer(firstName, lastName, userName, eMail, userPW);
            Console.WriteLine($"Thank you for Registering to Casa De Con'Sole', {firstName} {lastName}. You are now registered under the user name {userName}.");
            ShopMenu();
        }

        private void ShopMenu()
        {
            bool validChoice = false;
            int choice = -1;

            do
            {
                Console.WriteLine("Please Select an option from the following Menu:\n[1] Create an Order\n[2] View Past  Purchases\n[3]Cancel a Purchase\n[4] Logout");
                string userChoice = Console.ReadLine();
                validChoice = Int32.TryParse(userChoice, out choice);

                if (validChoice == false || choice < 1 || choice > 4)
                {
                    Console.WriteLine("That is not a valid selection. Please Try Again.");
                }
            } while (choice < 1 || choice > 4 || validChoice == false);

            switch (choice)
            {
                case 1:
                    CreateOrder();
                    break;
                case 2:
                    PastPurchases();
                    break;
                case 3:
                    CancelPurchase();
                    break;
                case 4:
                    Logout();
                    break;
            }
        }


        private void CreateOrder()
        {
            Console.WriteLine("Please Select a Location to Shop:");

        }

        private void PastPurchases()
        {
            throw new NotImplementedException();
        }
        private void CancelPurchase()
        {
            throw new NotImplementedException();
        }

        private void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
