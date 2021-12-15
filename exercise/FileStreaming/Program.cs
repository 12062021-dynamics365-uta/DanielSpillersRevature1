using System;
using System.IO;

namespace FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\File.txt", FileMode.OpenOrCreate);
            fs.WriteByte(12);
            fs.WriteByte(15);
            fs.WriteByte(16);
            fs.Close();

            FileStream f1 = new FileStream("C:\\File.txt", FileMode.OpenOrCreate);

            int i = 0;
            Console.WriteLine("The content of the files are ");
            while(((i=f1.ReadByte()) != -1))
                {
                Console.WriteLine(i);
            };

            FileStream f2 = new FileStream("C:\\File.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f2);
            string data = sr.ReadLine();


            Console.WriteLine("the data is in file as follow ");
            Console.WriteLine(data);
            sr.Close();
            f2.Close();
        }
    }
}
