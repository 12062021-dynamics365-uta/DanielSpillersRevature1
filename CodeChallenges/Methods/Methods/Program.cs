using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = GetName();
            GreetFriend(name);
            double x = GetNumber();
            double y = GetNumber();
            string typeAction = Console.ReadLine();
            int action;
            bool validAction = Int32.TryParse(typeAction, out action);
            DoAction(x, y, action);
        }

        public static string GetName()
        {
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
            bool validChoice = false;
            int choice;
            bool keepAsking  = false;
            do
            {
                Console.WriteLine("enter an integer");
                string choiceMade = Console.ReadLine();
                validChoice = int.TryParse(choiceMade, out choice);
                    if (validChoice == false)
                    {
                        Console.WriteLine("Try again.");

                    }
                else if(validChoice == true)
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
