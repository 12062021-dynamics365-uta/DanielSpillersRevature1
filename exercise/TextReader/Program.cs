using System;
using System.IO;

namespace TextReader1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter tw = File.CreateText("C:\\File1.txt"))
            {
                tw.WriteLine("this is my c# file");
                tw.WriteLine("textreader calss and text reader class example");
            }
            using (TextReader tr = File.OpenText("C:\\File1.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            
        }
    }
}