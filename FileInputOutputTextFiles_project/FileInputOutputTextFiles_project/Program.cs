using System;
using System.IO;

namespace FileInputOutputTextFiles_project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("F:/file1.txt"))
                {
                    string str = "Hello to BizRunTime";
                    sw.Write(str);
                }
                using(StreamReader sr=new StreamReader("F:/file1.txt"))
                {
                    string str;
                    while((str=sr.ReadLine())!= null)
                    {
                        Console.WriteLine(str);
                    }
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
