using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = GetName();
            GreetFriend(name);
            Console.WriteLine("Enter a Number");
            double x = GetNumber();
            Console.WriteLine("Enter a Second Number");
            double y = GetNumber();
            int action = GetAction();
            DoAction(x, y, action);
        }

        public static string GetName()
        {
            Console.WriteLine("Welcome. Enter your name.");
            string name = Console.ReadLine();
            return name;
        }

        public static string GreetFriend(string name)
        {
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            bool valid = false;
            double userNumber = 0.0;
            string userInput = Console.ReadLine();
            valid = double.TryParse(userInput, out userNumber);
            return userNumber;
        }

        public static int GetAction()
        {
            int choice;
            bool keepAsking  = false;
            do
            {
                bool validChoice = false;
                Console.WriteLine("enter an action");
                string choiceMade = Console.ReadLine();
                validChoice = int.TryParse(choiceMade, out choice);
                    if (validChoice == false)
                    {
                        Console.WriteLine("Try again.");

                    }
                else if(validChoice && choice >= 1 && choice <=4)
                {
                    return choice;
                }
            } while (!keepAsking);
            return choice;
        }

        public static double DoAction(double x, double y, int action)
        {
           switch(action)
            {
                case 1:
                    return x + y;
                case 2:
                    return y - x;
                case 3:
                    return x * y;
                case 4:
                    return x / y;
                default:
                    throw new FormatException("typeof(System.FormatException");
            }
        }
    }
}
