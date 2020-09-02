using System;
using System.IO;

namespace UsingAbstractStream_project
{
    class AbstractStream
    {
        static void Main(string[] args)
        {
            Stream s = new FileStream("foo.txt", FileMode.Create);//Stream:-provide a generic view of sequence of btye.This is a abstract class.
            s.WriteByte(77);
            s.WriteByte(127);
            s.Close();
        }
    }
}
//For writing bytes to the current file.