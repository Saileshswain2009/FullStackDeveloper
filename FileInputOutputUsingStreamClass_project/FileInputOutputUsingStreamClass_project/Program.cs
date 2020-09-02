using System;
using System.IO;

namespace FileInputOutputUsingStreamClass_project
{
    class StreamOperation
    {
        static void Main(string[] args)
        {
            try 
            {
                using(StreamWriter obj = new StreamWriter("F:/file.txt"))//Either use using or close to close the streamReader object obj.
                { 
                    string line="Hello C# World";//to take one by one character from file.txt.
                    obj.Write(line);//TO store on particular file:-write
                }
                using (StreamReader obj1 = new StreamReader("F:/file.txt"))//Either use using or close to close the streamReader object obj.
                {
                    string line;
                    while((line=obj1.ReadLine())!= null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)//Given particular class name or only exception.
            {
                Console.WriteLine("File couldn't be read");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();//ReadKey to see the output.
        }
    }
}
