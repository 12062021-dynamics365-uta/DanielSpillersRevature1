using System;

namespace p0_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logout = false;
            do
            {
                OrderLogic orderLogic = new OrderLogic();
                DbConnection database = new DbConnection();
                //WELCOME
                Console.WriteLine("Welcome to our Online Shop!\n");
                Console.WriteLine("We are an Exclusive Online Boutique\n");
                //LOGIN or REGISTER
                bool leaveLogin = false;
                do
                {
                    Console.WriteLine("Please type Login or Register");
                    string loginOrRegister = Console.ReadLine();
                    Console.Clear();
                    //LOGIN
                    if (loginOrRegister.ToUpper() == "LOGIN")
                    {
                        Console.WriteLine("Enter your Username:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter you password:");
                        string userPW = Console.ReadLine();
                        database.GetCustomer(userName, userPW);
                        Console.Clear();
                        Console.WriteLine($"Welcome Back, {userName}! ");
                        leaveLogin = !leaveLogin;
                    }
                    //REGISTER
                    else if (loginOrRegister.ToUpper() == "REGISTER")
                    {
                        Console.WriteLine("\nEnter your First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nLast Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("\nNew Username:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("\nE-mail address:");
                        string email = Console.ReadLine();
                        Console.WriteLine("\nEnter a Password for your user:");
                        string password = Console.ReadLine();
                        //add customer to database
                        database.AddCustomer(firstName, lastName, userName, email, password);
                        Console.Clear();
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
                    Console.Clear();
                    locValSelect = Int32.TryParse(storeSelection, out validLocation);
                    orderLogic.SelectStoreLocation(storeSelection, locValSelect, validLocation);

                    string correctLocation;
                    correctLocation = Console.ReadLine();

                    if (correctLocation.ToUpper() == "YES")
                    {
                        selectedLocation = !selectedLocation;
                        Console.Clear();
                    }
                    else if (correctLocation.ToUpper() == "NO")
                        continue;
                    else
                        Console.WriteLine("That is an invalid selection.");
                } while (!selectedLocation);
                //PRODUCTS
                bool moveToPay = false;
                bool productSelection = false;
                string productSelecting;
                bool productValSelect = false;
                int validProduct;
                //DISPLAY AVAILABLE PRODUCTS
                orderLogic.DisplayProducts();
                Console.WriteLine("Please type the number of the product you want to use to select your product and press ENTER.");
                productSelecting = Console.ReadLine();
                do
                {   //ALLOW PRODUCTS SELECTION
                    productValSelect = Int32.TryParse(productSelecting, out validProduct);
                    do
                    {
                        orderLogic.EvaluateProductSelection(validProduct);
                        moveToPay = !moveToPay;
                    } while (!moveToPay);

                    //VIEW CURRENT CART
                    bool checkout = false;
                    do
                    {
                        Console.WriteLine("Review your cart? Type REVIEW. Type CHECKOUT to purchase your order. Type REMOVE to delete an item from your cart.");
                        string viewCart = Console.ReadLine();
                        Console.Clear();
                        if (viewCart.ToUpper() == "REVIEW")
                        {
                            orderLogic.ViewCurrentCart();
                            Console.WriteLine("\n\n\nYour Current Total is: " + orderLogic.CartTotal());
                        }
                        else if (viewCart.ToUpper() == "CHECKOUT")
                        {
                            checkout = !checkout;
                        }                        
                       else if (viewCart.ToUpper() == "REMOVE")
                        {
                            orderLogic.RemoveItemFromCart();
                            checkout = !checkout;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        };

                    } while (!checkout);
                    //TOTAL
                    Console.WriteLine("\n\n\nYour purchase total is: $" + orderLogic.CartTotal());
                    //PURCHASE OR CANCEL
                    orderLogic.ProceedOrCancel();
                    productSelection = !productSelection;
                } while (!productSelection);
                //NEW ORDER or VIEW PAST ORDERS
                bool completedSession = false;
                do
                {   //VIEW PREVIOUS PURCHASES
                    string viewPreviousPurchases;
                    Console.WriteLine("Would you like to review your purchases? Type YES to view you purchases or anything else to logout.");
                    viewPreviousPurchases = Console.ReadLine();
                    if(viewPreviousPurchases.ToUpper() == "YES")
                    {
                        orderLogic.GetPastPurchases();
                    }
                    else
                    {completedSession = !completedSession;}
                } while (!completedSession);
                logout = !logout;
            } while (!logout);
        }
    }
}
