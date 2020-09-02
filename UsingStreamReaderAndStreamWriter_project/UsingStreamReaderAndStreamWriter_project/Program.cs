using System;
using System.IO;
using System.Text;

namespace UsingStreamReaderAndStreamWriter_project
{
    class StreamWriterOperation
    {
        static void Main(string[] args)
        {
            Stream fs = new FileStream("zoo.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.ASCII);
            sw.Write("Hello Brother");
            sw.Close();
        }
    }
}
