using System;
using System.IO;
using System.Text;

namespace StreamWriterUsingStreamBuilder_project
{
    class StreamWriter
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter();
            WriteHello(sw);
            Console.WriteLine(sb);
        }
        static void WriteHello(TextWriter tw)
        {
            tw.Write("Hello SAILESH,string I/O!");
        }
    }
}
