using System;
using System.IO;

namespace FileAttributes_project
{
    class FileAttributeOperations
    {
        static void Main(string[] args)
        {
            FileAttributes attributes = File.GetAttributes("F:/temp/MyText.txt");
            if((attributes & FileAttributes.ReadOnly)==FileAttributes.ReadOnly)
            {
                Console.WriteLine("read-only File");
            }
            else
            {
                Console.WriteLine("Not read-only Files");
            }
        }
    }
}
