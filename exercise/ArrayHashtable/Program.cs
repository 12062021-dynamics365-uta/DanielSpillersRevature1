using System;
using System.Collections;

namespace ArrayHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("eid", 1001);
            ht.Add("name", "Daniel");
            ht.Add("Job", "Software Dev");
            ht.Add("Salary", 55000);
            ht.Add("location", "remote");

            foreach(object obj in ht.Keys)
            {
                Console.WriteLine(obj + ": " + ht[obj]);
            }
            Console.WriteLine("location: " + ht["location"]);


            //search for a particular key
            Console.WriteLine("Does Color exist? " + ht.ContainsKey("color"));
            Console.WriteLine("Does location exist? " + ht.ContainsKey("location"));

        }
    }
}
