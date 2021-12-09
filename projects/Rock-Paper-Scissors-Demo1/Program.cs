using System;

namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			//variables
			int computerGuess;
			int userWins = 1;
			int cpuWins = 1;
			int ties = 0;
			int convertedNumber = -1;
			bool conversionBool = false;

			//get input form the user
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");

			do
			{
				Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
				string userInput = Console.ReadLine();

				conversionBool = Int32.TryParse(userInput, out convertedNumber); //this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.

				//validate the user input as a 1, 2, or 3
				if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
				{
					Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
				}

			} while (!(convertedNumber > 0 && convertedNumber < 4));

			Random randNum = new Random();
			computerGuess = randNum.Next(1, 4);

			do
			{
				if (convertedNumber == 1 && computerGuess == 2)
				{
					Console.WriteLine("The Computer Wins! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					cpuWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == 1 && computerGuess == 3)
				{
					Console.WriteLine("You Win! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					userWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == 2 && computerGuess == 1)
				{
					Console.WriteLine("You Win! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					userWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == 2 && computerGuess == 3)
				{
					Console.WriteLine("The Computer Wins! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					cpuWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == 3 && computerGuess == 1)
				{
					Console.WriteLine("The Computer Wins! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					cpuWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == 3 && computerGuess == 2)
				{
					Console.WriteLine("You Win! Next Round");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					userWins++;
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
				else if (convertedNumber == computerGuess)
				{
					Console.WriteLine("The Game is a Tie.");
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					ties++; 
					string userInput = Console.ReadLine();
					computerGuess = randNum.Next(1, 4);
				}
			} while (userWins < 2 || computerGuess < 2);

				if (userWins == 2 && cpuWins < 2)
				{
					Console.WriteLine("You won again!");
					Console.WriteLine($"Congratulations! You Win. The number of ties between you and the computer was {ties}. Good game :)");
				} 
				else if (cpuWins == 2) 
				{
					Console.WriteLine("Uh-Oh! It looks like the computer got the best of you!");
					Console.WriteLine($"The Computer got the best of you this time! The amount of ties between you and the computer was {ties}. :(");
				}
		}
	}
}
