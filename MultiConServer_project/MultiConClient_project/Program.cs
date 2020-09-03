using System;
using System.Net;
using System.Net.Sockets;

namespace MultiConClient_project
{
    class Client
    {
        public static void Main(string[] args)
        {
            clientOpera();
        }
        public static void clientOpera()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect("127.0.0.1", 8);
            s.Close();
            s.Dispose();
        }
    }
}
