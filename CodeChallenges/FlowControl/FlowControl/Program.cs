using System;
using System.IO;
using System.Linq;

namespace _6_FlowControl
{
    public class Program
    {

        private static string username;
        private static string password;

        static void Main(string[] args)
        {



            Random rnd = new Random();
            Program run = new Program();
            int validTemperature = rnd.Next(-40, 135);
        }

        /// <summary>
        /// This method gets a valid temperature between -40 and 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {
            string getTemp = Console.ReadLine();
            int validTemperature;
            bool validateTemp = Int32.TryParse(getTemp, out validTemperature);
            if ( validTemperature >= -40 && validTemperature < 135)
            { return validTemperature;}
            return validTemperature;
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            if (temp < -20) { Console.Write("hella cold"); }
            else if (temp >= -20 && temp < 0) { Console.Write("pretty cold"); }
            else if (temp >= 0 && temp < 20) { Console.Write("cold"); }
            else if (temp >= 20 && temp < 40) { Console.Write("thawed out"); }
            else if (temp >= 40 && temp < 60) { Console.Write("feels like Autumn"); }
            else if (temp >= 60 && temp < 80) { Console.Write("perfect outdoor workout temperature"); }
            else if (temp >= 80 && temp < 90) { Console.Write("niiice"); }
            else if (temp >= 90 && temp < 100) { Console.Write("hella hot"); }
            else if (temp >= 100 && temp <  135) { Console.Write("hottest"); }
        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            username = Console.ReadLine();
            password = Console.ReadLine();
            Console.WriteLine($"saved: username: {username} password: {password}");
        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {
            string usernameCheck = Console.ReadLine();
            string passwordCheck = Console.ReadLine();

            if (usernameCheck == username && passwordCheck == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            var result = temp <= 42 ? $"{temp} is too cold!" : temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" : temp > 78 ? $"{temp} is too hot!" : "no result";
            Console.WriteLine(result);
        }


    }//EoP
}//EoN
