using System;
using System.Collections.Generic;

namespace GenericList
{
    class ST
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Console.WriteLine("intial capacity of list " + intList.Capacity);
            intList.Add(10);
            Console.WriteLine("New capacity of list " + intList.Capacity);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            Console.WriteLine("Third capacity of list " + intList.Capacity);
            intList.Add(50);
            Console.WriteLine("Final capacity of list " + intList.Capacity); 

            foreach( int i in intList)
            {
                Console.WriteLine(i + "");
            }


            Stack<int> st = new Stack<int>();


        }
    }
}