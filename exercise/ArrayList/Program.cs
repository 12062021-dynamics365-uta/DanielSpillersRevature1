using System;
using System.Collections;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist1 = new ArrayList();
            arrlist1.Add("Daniel");
            arrlist1.Add("Anthony");
            arrlist1.Add("Spillers");
            arrlist1.Add(23);
            arrlist1.RemoveAt(1);
            arrlist1.Insert(1, 40);

            foreach(object i in arrlist1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
