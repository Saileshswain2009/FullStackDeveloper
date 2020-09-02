using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientOpera_project
{
    class Client
    {
        public static void Main(string[] args)
        {
            Client c = new Client();
            c.CliMessage();
        }
        public void CliMessage()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994);
            s.Connect(endPoint);
            Console.Write("Enter Message");
            String str = Console.ReadLine();
            byte[] strBuffer = Encoding.Default.GetBytes(str);
            s.Send(strBuffer, 0, strBuffer.Length, 0);
            byte[] buffer = new byte[255];
            int rec = s.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);
            Console.WriteLine("Received: {0}", Encoding.Default.GetString(buffer));
            Console.Read();
        }
    }
}