using System;
using Domain;
using Storage;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logout = false;
            do
            {
                Order order = new Order();
                OrderLogic orderLogic = new OrderLogic();
                DbConnection database = new DbConnection();
                Product products = new Product();

                //WELCOME

                    Console.WriteLine("Welcome to our Online Shop!\n");
                    Console.WriteLine("We are an Exclusive Online Boutique\n");

                //LOGIN or REGISTER

                    bool leaveLogin = false;
                    do
                    {
                        Console.WriteLine("Please type Login or Register");
                        string loginOrRegister = Console.ReadLine();

                //LOGIN

                    if (loginOrRegister.ToUpper() == "LOGIN")
                    {
                        Console.WriteLine("Username:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("password:");
                        string userPW = Console.ReadLine();
                        database.GetCustomer(userName, userPW);
                        orderLogic.Login(userName, userPW);
                        leaveLogin = !leaveLogin;
                    }

                //REGISTER

                    else if (loginOrRegister.ToUpper() == "REGISTER")
                        {
                            int customerId = 1;
                            Console.WriteLine("\nEnter your First Name");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("\nLast Name");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("\nNew Username:");
                            string userName = Console.ReadLine();
                            Console.WriteLine("\nE-mail address:");
                            string email = Console.ReadLine();
                            Console.WriteLine("\nEnter a Password for your user:");
                            string userPW = Console.ReadLine();
                            //add customer to database
                            database.AddCustomer(++customerId, firstName, lastName, userName, email, userPW);

                            //orderLogic.Register(firstName, lastName, userName, userPW);

                            Console.WriteLine($"\nWelcome to Casa De Con'Sole', {firstName} {lastName}." +
                                $"\nYou are logged in as user {userName}");

                            leaveLogin = !leaveLogin;
                        }

                    } while (!leaveLogin);


                //LOCATION
                    bool selectedLocation = false;
                    do
                    {
                        string storeSelection;
                        bool locValSelect = false;
                        int validLocation;

                        Console.WriteLine("\n\nPlease choose from one of our exclusive merchadising locations.\nSelect by the number of the location." +
                        "\nFor example, select New York by entering 1.");
                        Console.WriteLine("\n1: NYC\n2: Chicago\n3: Los Angeles\n4: Tokyo");
                        storeSelection = Console.ReadLine();

                        locValSelect = Int32.TryParse(storeSelection, out validLocation);
                        orderLogic.SelectStoreLocation(storeSelection, locValSelect, validLocation);

                        string correctLocation;
                        correctLocation = Console.ReadLine();

                        if (correctLocation.ToUpper() == "YES")
                            selectedLocation = !selectedLocation;
                        else if (correctLocation.ToUpper() == "NO")
                            continue;
                        else 
                            Console.WriteLine("That is an invalid selection.");
                    } while (!selectedLocation);


                //PRODUCTS
                    bool productSelection = false;
                    do
                    {
                    string productSelecting;
                    bool productValSelect = false;
                    int validProduct;
                    
                //DISPLAY AVAILABLE PRODUCTS
                    database.ViewProducts();

                    //ALLOW PRODUCTS SELECTION

                    Console.WriteLine("Please type the number of the product you want to use to select your product and press ENTER.");
                    productSelecting = Console.ReadLine();
                    productValSelect = Int32.TryParse(productSelecting, out validProduct);


                    //VIEW CURRENT CART

                    //MOVE TO PURCHASE
                    bool readyToBuy = false;
                    do
                    {
                        readyToBuy = !readyToBuy;
                    } while (!readyToBuy);

                } while (!productSelection);

                //ORDER
                    bool calculateOrder = false;
                    do
                    {

                //PURCHASE OR CANCEL

                    } while (!calculateOrder);

                //NEW ORDER or VIEW PAST ORDERS
                    bool completedSession = false;
                    do
                    {

                //NEW ORDER

                //VIEW PREVIOUS PURCHASES

                    } while (!completedSession);

                //LOGOUT

            } while (!logout);
        }
    }
}
