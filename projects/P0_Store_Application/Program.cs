using System;

namespace P0_Store_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string storeSelection;
            int validLocation;
            bool locValSelect = false;
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
            storeSelection = Console.ReadLine();

            //validates selection
            locValSelect = Int32.TryParse(storeSelection, out validLocation);

            //if statement to show inventory for correct store product
            if (validLocation == 1)
            {
                Console.WriteLine("Here is what we have available in New York:" +
                    "\n1: X-Box Series X Controller" +
                    "\n2: Playstation 5 Headset" +
                    "\n3: Nintendo Switch Skins" +
                    "\n4: X-Box Series S Cooling Stand" +
                    "\n5: Playstation 5 Gaming Headset" +
                    "\n6: Blue Yeti USB Mic" +
                    "\n7: NBA 2K22" +
                    "\n8: MLB The Show" +
                    "\n9: Madden 22");
            }
            if (validLocation == 2)
            {
                Console.WriteLine("Here is what we have available in Chicago:" +
                    "\n1: Hardwood Classics Knicks Jersey" +
                    "\n2: Wilson Official NBA Basketball" +
                    "\n3: Compression Arm Sleeve" +
                    "\n4: Air Jordan Retro 12" +
                    "\n5: Nike Basketball Compression Socks" +
                    "\n6: Basketball Pump" +
                    "\n7: Nike Basketball Shorts" +
                    "\n8: NBA training coness" +
                    "\n9: SKLZ Dribble Stick");
            }
            if (validLocation == 3)
            {
                Console.WriteLine("Here is what we have available in Los Angeles:" +
                    "\n1: Apple iPhone 13" +
                    "\n2: Apple iPhone 13 Pro" +
                    "\n3: Apple iPhone 13 Pro Max" +
                    "\n4: Apple Watch Series 6" +
                    "\n5: Samsung S21" +
                    "\n6: Samsung S21 Ultra 5G" +
                    "\n7: Samsung Z Flip3 5G" +
                    "\n8: Samsung Z Fold3 5G" +
                    "\n9: Samsung Galaxy Buds2");
            }
            if (validLocation == 4)
            {
                Console.WriteLine("Here is what we have available in Tokyo:" +
                    "\n1: Pokemon Let's Go! Pikachu" +
                    "\n2: Pokemon Brilliant Diamond" +
                    "\n3: Pokemon Shining Pearl" +
                    "\n4: Pokemon Legends: Arceus" +
                    "\n5: Pokemon Sword" +
                    "\n6: Rare Pokemon Shiny Mew Trading Card" +
                    "\n7: Rare Pokemon Shiny Mewtwo Trading Card" +
                    "\n8: Rare Pokemon Shiny Pikachu Trading Card" +
                    "\n9: Nintendo Switch");
            }

            //validates product selection
            prodValSelect = Int32.TryParse(storeSelection, out validLocation);

            //Pricing Options
            if (validLocation == 1 &&)
        }
    }
}
