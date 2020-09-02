using System;
using System.IO;

namespace FileInputOutputUsingFileStream_project
{
    class FileStreamOperation
    {
        static void Main(string[] args)
        {
            FileStream obj = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for(int i=1;i<=10;i++)
            {
                obj.WriteByte((byte)i);//WriteByte():takes only byte but here we provide int.so,castng needed.
            }
            obj.Position = 0;//relocate the pointer to starting position.
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(obj.ReadByte()+" ");//reading bytes one by one.
            }
            obj.Close();//File object must be close after the operation.
            Console.ReadKey();//use as get,set from scan.F and to see the output.
        }
    }
}
//File is something which we can used from outside to read and write something in it.