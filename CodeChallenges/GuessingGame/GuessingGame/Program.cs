using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {

        public static void Main(string[] args)
        {
            bool startOver;
            List<int> guessNums = new List<int>();
            do
            {
                int userTurns = 0;
                string userGuesses = $"Your Guesses are: {guessNums} ";
                Console.WriteLine("Welcome to my Guessing Game.");
                int randomNum = GetRandomNumber();
                Console.WriteLine("The computer has selected a guess. Now you have 10 tries to match that guess or you lose.");

                do
                {
                    Console.WriteLine("Please enter your guess.");
                    int guess = GetUsersGuess();
                    int round = CompareNums(randomNum, guess);
                   guessNums.Add(guess);
                    if (round == -1)
                    {
                        Console.WriteLine("Your guess is too high, try again.");
                        userTurns++;
                        Console.WriteLine(userGuesses);
                    }
                    else if (round == 1)
                    {
                        Console.WriteLine("Your guess is too low, try again.");
                        userTurns++;
                        Console.WriteLine(userGuesses);
                    }
                    else if (round == 0)
                    {
                        Console.WriteLine("You Win! Great Job!");
                        userTurns = -1;
                        Console.WriteLine(userGuesses);
                    }
                } while (userTurns < 10 && userTurns != -1);


                if (userTurns == 10)
                {
                    Console.WriteLine("Nice try. The computer got the best of you this time, though.");
                }
                else if (userTurns == -1)
                {
                    Console.WriteLine("Congrats on your Win!!!!");
                }
                foreach(int s in guessNums)
                {
                    Console.WriteLine(userGuesses);
                }
                    startOver = PlayGameAgain();
            } while (startOver == true);
        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            int randomNum = 0;
            Random random = new Random();
           return randomNum = random.Next(0, 101);
        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            string userInput = Console.ReadLine();
            int userGuess = 0;
            bool evalInput = Int32.TryParse(userInput, out userGuess);
            return userGuess;
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randomNum, int guess)
        {
            int result;
           if (randomNum < guess)
            {
                result = -1;
            }
           else if (randomNum == guess)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
           return result;
        }

        /// <summary>
        /// This method offers the user the chance to play again. 
        /// It returns true if they want to play again and false if they do not.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool PlayGameAgain()
        {
            bool playAgain = false;
            Console.WriteLine("Would you like to play again?\nEnter 1 for yes\nEnter 2 for no");
            string userAnswer = Console.ReadLine();
            int yesOrNo = 0;
            bool evalInput = Int32.TryParse(userAnswer, out yesOrNo);

            if (yesOrNo == 1)
            {
                return !playAgain;
            }
            else if (yesOrNo == 2)
            {
                return playAgain;
            }
            else return playAgain;
        }
    }
}
