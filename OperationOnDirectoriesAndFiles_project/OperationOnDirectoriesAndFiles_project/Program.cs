using System;
using System.IO;

namespace OperationOnDirectoriesAndFiles_project
{
    class FileStreamOperation
    {
        static void Main(string[] args)
        {
            try
            {
                Stream s = File.OpenRead(args[0]);//OpenRead:-open an existing file for reading.
                StreamReader sr = new StreamReader(s);
                Console.WriteLine(sr.ReadLine());
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
