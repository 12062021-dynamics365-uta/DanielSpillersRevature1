using System;

namespace P0_Store_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            
            bool exitShop = false;
            do
            {
                OrderLogic logIn = new OrderLogic();

                // WELCOME MESSAGE
                Console.WriteLine("Welcome to our Online Shop!\n");
                Console.WriteLine("We are an Exclusive Online Boutique");

                //LOGIN OR REGISTER
                Console.WriteLine("You Must Login or Register to shop with us");
                Console.WriteLine("Please type Login or Register");
                string loginOrRegister = Console.ReadLine();



                //LOGIN

                bool leaveLogin = false;
                do
                {
                    if (loginOrRegister.ToUpper() == "LOGIN")
                    {

                        Console.WriteLine("Welcome back! Please enter your Username");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Please enter your password below");
                        string userPw = Console.ReadLine();
                        //logIn.Login(userName, userPw);
                        Console.WriteLine("\n\nWelcome to Casa De Con'Sole");
                        leaveLogin = !leaveLogin;
                    }


                    //REGISTER
                    else if (loginOrRegister.ToUpper() == "REGISTER")
                    {
                        //REGISTER USER MESSAGE
                        Console.WriteLine("Thank you for choosing Casa De Con'Sole.\n\n\n\n");


                        //GATHERS NEW CUSTOMER INFORMATION
                        Console.WriteLine("Please enter your first name");
                        string userFname = Console.ReadLine();
                        Console.WriteLine("Please enter your last name");
                        string userLname = Console.ReadLine();
                        Console.WriteLine("Please enter your username");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Please enter your password");
                        string userPw = Console.ReadLine();

                        Console.WriteLine("Thank you and welcome to Casa De Con'Sole");
                        leaveLogin = !leaveLogin;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, but you can only login or register to shop.");
                        Console.WriteLine("Please type login or register");
                        Console.WriteLine("If you would like to sign out, please type goodbye");
                        loginOrRegister = Console.ReadLine();

                        if (loginOrRegister.ToUpper() == "GOODBYE")
                        {
                            leaveLogin = !leaveLogin;
                        }
                    }
                } while (!leaveLogin);

                //Method to Print the Locations//Validate Location Selection

                bool moveToProducts = false;

                do
                {

                    string storeSelection;
                    Console.WriteLine(
                        "\n\n" +
                        "Please choose from one of our exclusive merchadising locations." +
                        "\nPlease Select by the number of the location." +
                        "\nFor example, select New York by entering 1."
                        );
                    Console.WriteLine("\n1: NYC\n2: Chicago\n3: Los Angeles\n4: Tokyo");
                    storeSelection = Console.ReadLine();

                    bool locValSelect = false;
                    int validLocation;

                    locValSelect = Int32.TryParse(storeSelection, out validLocation);

                    if (!locValSelect || validLocation < 1 || validLocation > 4)
                    {
                        Console.WriteLine("That is not a valid choice. Please choose again");
                    }
                    else
                    {
                        Console.WriteLine($"You Chose: " + (Locations)validLocation + ". If that the correct store? Yes or No");
                    };


                    string correctLocation;
                    correctLocation = Console.ReadLine();

                    if (correctLocation.ToUpper() == "YES")
                    {
                        moveToProducts = !moveToProducts;

                    }
                    else if (correctLocation.ToUpper() == "NO")
                    {
                        continue;
                    } else
                    {
                        Console.WriteLine("That is an invalid selection.");
                    }

                } while(!moveToProducts);


                //PRODUCT SELECTION

                bool readyToPay = false;

                do
                {
                    Console.WriteLine("\n\n\n");


                    //PRINTS INVENTORY


                    var orderList = new Inventory();
                    var inventoryList = new Inventory();
                    inventoryList.ListInventory();

                    Console.WriteLine(
                        "\n\nReview the products in the list." +
                        "\nSelect the Product number");

                    //VALIDATE INVENTORY SELECTION

                    string productionSelection = Console.ReadLine();
                    bool inventoryValid = false;
                    int validInventoryItem;

                    inventoryValid = Int32.TryParse(productionSelection, out validInventoryItem);

                    if (!inventoryValid || validInventoryItem < 1 || validInventoryItem > 10)
                    {
                        orderList.ListOrder(validInventoryItem);
                    }

                } while (!readyToPay);



               // moveToProducts = !moveToProducts;




                //METHOD TO DISPLAY AND VALIDATE INVENTORY

                bool validProductSelected = false;


                //var inventoryList = new Inventory();

                //inventoryList.ListInventory();



                //Method to 


                //EXIT THE PROGRAM


                //else
                //{
                //    exitShop = !exitShop;
                //}



            } while (exitShop);


            int prodValidation;
            string productSelection;
            bool prodValSelect = false;

            //selects store location
            productSelection = Console.ReadLine();

            //validates product selection
            prodValSelect = Int32.TryParse(productSelection, out prodValidation);

            //Pricing Options
            if (prodValidation == 1)
            {
                Console.WriteLine("working");
            }
        }
    }
}
