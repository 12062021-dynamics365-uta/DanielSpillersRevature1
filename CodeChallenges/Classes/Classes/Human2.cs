using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    public class Human2
    {
        private string lastName = "Smyth";
        private string firstName = "Pat";
        private string eyeColor;
        private int age;
        public int Weight { get; set; }

        public Human2() { }
        public Human2(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human2(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human2(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
    }

        public void AboutMe2()
        {
            string FAndLName = $"My name is {firstName} {lastName}. ";
            string myAge = $"My age is {age}. ";
            string myEyes = $"My eye color is {eyeColor}. ";
            
            if (myAge != null &&  myEyes != null)
            {
                Console.WriteLine(FAndLName + myAge + myEyes);
            }
            else if(myEyes != null && myAge == null)
            {
                Console.WriteLine(FAndLName + myEyes);
            }else if (myEyes == null && myAge != null)
            {
                Console.WriteLine(FAndLName + myAge);
            }
            else
            {
                Console.WriteLine(FAndLName);
            }
        }

        public int WeightSet(int weight)
        {
            if(weight < 0 || weight > 400)
            { weight = 0; }
            else { return weight;}
            return weight;
        }

    }
}