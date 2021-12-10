using System;

namespace Two_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 55, 156, 17, 24, 130, 308};
            Console.WriteLine("the array contains the below element");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");

            }

            Console.WriteLine();
            Array.Sort(arr);
            Console.WriteLine("The array after sorting");
            foreach(int i in arr)
            {
                Console.WriteLine(i + "");
            }

            Console.WriteLine("The New Array");
            //copy an array
            int[] brr = new int[10];
            Array.Copy(arr, brr, 5);

            foreach(int i in brr)
            {
                Console.WriteLine(i + "");
            }



        }//EoM
    }//EoC
}//EoN
