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

                var inventoryList = new Inventory();

                inventoryList.ListInventory();

                // Welcome Message!!!
                Console.WriteLine("Welcome to our Online Shop!\n");
                Console.WriteLine("We are an Exclusive Online Boutique");
                Console.WriteLine("You Must Login or Register to shop with us");
                Console.WriteLine("Please type Login or Register");
                string loginOrRegister = Console.ReadLine();

                //LOGIN
                if (loginOrRegister.ToUpper() == "LOGIN")
                {
                    Console.WriteLine("Please enter your Username");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your password below");
                    string userPw = Console.ReadLine();
                }
                

                //REGISTER
                else if (loginOrRegister.ToUpper() == "REGISTER" )
                {
                    Console.WriteLine("Please enter your first name");
                    string userFname = Console.ReadLine();
                    Console.WriteLine("Please enter your last name");
                    string userLname = Console.ReadLine();
                    Console.WriteLine("Please enter your username");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    string userPw = Console.ReadLine();
                    Console.WriteLine("Please enter your payment method: Visa, Mastercard, Apple Pay");
                    string userPayMethod = Console.ReadLine();

                    Customer registration = new Customer(userFname, userLname, userName, userPw, userPayMethod);
                    


                    Console.WriteLine("Thank you and welcome to Casa De Console");
                }

                //Method to Print the Locations//Validate Location Selection

            //bool locValSelect = false;
            //int validLocation;
            //string storeSelection;


            //SELECTS STORE LOCATION


            //storeSelection = Console.ReadLine();


            //VALIDATES SELECTION

            
            //locValSelect = Int32.TryParse(storeSelection, out validLocation);

                //METHOD TO DISPLAY AND VALIDATE INVENTORY

                //var inventoryList = new Inventory();

                //inventoryList.ListInventory();



                //Method to 
                

                //EXIT THE PROGRAM
                else
                {
                    exitShop = !exitShop;
                }



            } while (exitShop);


            int prodValidation;
            string productSelection;
            bool prodValSelect = false;


            //introduction messssage

            Console.WriteLine("Welcome to our Online Shop!\n" +
                "We Have 4 locations. Please select a location to begin viewing inventory");
            Console.WriteLine("Select from the following menu:" +
                "\n1: New York" +
                "\n2: Chicago" +
                "\n3: Los Angeles" +
                "\n4: Tokyo");

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
