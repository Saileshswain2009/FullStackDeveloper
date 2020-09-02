using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_project
{
    class ClientOpera
    {
        static Socket sck;
        public static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }
            Console.WriteLine("Enter text");
            String str = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(str);
            sck.Send(data);
            Console.Write("Data send!\r\n");
            Console.Write("Press any key to continue...");
            Console.Read();
            sck.Close();
        }
    }
}
