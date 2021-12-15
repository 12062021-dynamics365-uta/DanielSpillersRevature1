using System;
using System.IO;

namespace BinaryReader1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\File3.txt", FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"C:\\File3.txt");
                writer.Write(10);
                writer.Write(true);
            }

            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;


            using (BinaryReader reader = new BinaryReader(File.Open("C:\\File3.txt", FileMode.Open)))
            {
                aspectRatio = reader.ReadSingle();
                tempDirectory = reader.ReadString();
                autoSaveTime = reader.ReadInt32();
                showStatusBar = reader.ReadBoolean();

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
}
