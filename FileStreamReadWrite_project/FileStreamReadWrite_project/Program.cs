using System;
using System.IO;

namespace FileStreamReadWrite_project
{
    class FileReadWrite
    {
        static void Main(string[] args)
        {
            string path = @"F:\temp\Mytext.txt";
            if(!File.Exists(path))
            {
                using(StreamWriter sw=File.CreateText(path))
                {
                    sw.WriteLine("SAILESH ");
                    sw.WriteLine("KUMAR ");
                    sw.WriteLine("SWAIN");
                }
            }
            using(StreamReader sr=File.OpenText(path))
            {
                string s;
                while((s=sr.ReadLine())!=null)
                Console.WriteLine(s);
            }
        }
    }
}
