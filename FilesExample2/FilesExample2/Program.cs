using System;
using System.IO;

namespace FilesExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream M = new FileStream("test.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 10; i++)
            {
                M.WriteByte((byte)i);
            }

            M.Position = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(M.ReadByte() + " ");
            }
            M.Close();
        }
    }
}
