using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
          
            string getWeight = Console.ReadLine();


            Human pSmyth = new Human();
            Human klayKlay = new Human("Klay", "Thompson");
            pSmyth.AboutMe();
            klayKlay.AboutMe();


            Human2 likeMike = new Human2("Michael", "Jordan", "brown");
            Human2 kingJames = new Human2("Lebron", "James", 37);
            Human2 chefCurry = new Human2("Stephen", "Curry", "green", 33);
            likeMike.AboutMe2();
            kingJames.AboutMe2();
            chefCurry.AboutMe2();

        }
    }
}
