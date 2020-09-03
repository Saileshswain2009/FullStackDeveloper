using System;
using System.IO;

namespace FilesExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to c# World";
            File.WriteAllText("fileName.txt", str1);

            string str2 = File.ReadAllText("fileName.txt");
            Console.WriteLine(str2);
        }
    }
}
