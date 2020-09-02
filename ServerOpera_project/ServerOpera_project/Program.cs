using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerOpera_project
{
    class Server
    {
        public static void Main(string[] args)
        {
            Server se = new Server();
            se.SocMessage();
        }
        public void SocMessage()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(new IPEndPoint(0, 1994));
            s.Listen(0);
            Socket acc = s.Accept();
            byte[] buffer = Encoding.Default.GetBytes("Hello client");
            acc.Send(buffer, 0, buffer.Length, 0);
            buffer = new byte[255];
            int rec = acc.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);
            Console.WriteLine("Received: {0}", Encoding.Default.GetString(buffer));
            s.Close();
            acc.Close();
            Console.Read();
        }
    }
}
