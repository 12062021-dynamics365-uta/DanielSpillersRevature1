using System;
using System.Collections;
using System.Collections.Generic;

namespace SweetnSaltyConsole_daniel_spillers
{
    class Program
    {
        static void Main(string[] args)
        {
            RunNumbers();

        }
                public static void RunNumbers()
                {
              ArrayList myAL = new ArrayList();
                    int sweetCount = 0;
                    int saltyCount = 0;
                    int sweetNSaltyCount = 0;

                    for (int i = 1; i < 1000; i++)
                    {

                        if(i % 20 == 0)
                       {
                            Console.WriteLine();
                       }

                        if (i % 5 == 0 && i % 3 == 0 && i > 1)
                        {
                            Console.Write("Sweet n Salty, ");
                            sweetNSaltyCount++;
                        }
                        else if (i % 3 == 0 && i > 1)
                        {
                            Console.Write("Sweet, ");
                            sweetCount++;
                        }
                        else if (i % 5 == 0 && i > 1)
                        {
                            Console.Write("Salty, ");
                            saltyCount++;
                        }
                        else
                        {
                            Console.Write($"{ i}, ");
                        }

                        if (i == 999)
                        {
                                Console.WriteLine($"\n\n\n\nSweet appeared {sweetCount} times.");
                                Console.WriteLine($"Salty appeared {saltyCount} times");
                                Console.WriteLine($"Sweet N Salty appeared {sweetNSaltyCount} times");
                        }

                    }



  
                 }
    }

}
