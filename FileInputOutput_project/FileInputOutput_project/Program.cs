using System;
using System.IO;


namespace FileInputOutput_project
{
    class FileInOut
    {
        static void Main(string[] args)
        {
            WriteToFile wr = new WriteToFile();
            wr.Data();
            Console.ReadKey();
        }
        public void Data()
        {
            StreamWriter sw = new StreamWriter("F://bizruntime.txt");//StreamWriter is used for text writing on a particular place.
            Console.WriteLine("Enter the Text that you want to write on File");
            string str = Console.ReadLine();
            sw.WriteLine();//To write a aline in the buffer.
            sw.Flush();// To write in output stream 
            sw.Close();
        }
    }
}
