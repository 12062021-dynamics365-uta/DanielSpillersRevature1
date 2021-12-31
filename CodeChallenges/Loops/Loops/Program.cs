using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int sum = 0;
            for (int i = 0; i < x.Count; i++)
            {
                if(x[i] % 2 != 0)
                {
                    sum++;
                }
            }
                return sum;
        } 

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
            int total = 0;

            foreach(object ob in x)
            {
                Type type = ob.GetType();
                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Int16:
                        if ((Int16)ob % 2 == 0)
                        { total++; }
                        break;
                    case TypeCode.UInt16:
                        if ((UInt16)ob % 2 == 0)
                        { total++; }
                        break;
                    case TypeCode.Int64:
                        if ((Int64)ob % 2 == 0)
                        { total++; }
                        break;
                    case TypeCode.Int32:
                        if ((Int32)ob % 2 == 0)
                        { total++; }
                        break;
                    case TypeCode.UInt32:
                        if ((UInt32)ob % 2 == 0)
                        { total++; }
                        break;
                    case TypeCode.UInt64:
                        if ((UInt64)ob % 2 == 0)
                        { total++; }
                        break;
                }
            }
                return total;
        }
        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            bool whileDone = false;
            int sum = 0;
                while (!whileDone)
                {
                for (int i = 0; i < x.Count;i++)
                {
                    if(x[i] % 4 == 0)
                    {
                        sum++;
                    }
                    else if(x[i] == 1234)
                    {
                        whileDone = !whileDone;
                        break;
                    }
                }
            };
                return (int)sum;
        }
        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
            int sum = 0;

            for(int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] %3 == 0 && x[i] % 4 == 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            string newString = ""; 
            
            foreach (var list in stringListArray) 
            { 
                foreach (string str in list) 
                { 
                    newString += (str + " "); 
                } 
            }
            return newString;
        }
    }
}