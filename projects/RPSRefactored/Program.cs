using System;

namespace RPSRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors!")
            Console.WriteLine("What is your First Name?");
            string userFName = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            string userLName = Console.ReadLine();

            GamePlayLogic game = new GamePlayLogic(userFName, userLName);
            //save the name as a player
        }

        
    }
}
