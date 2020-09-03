using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace MultiConServer_project
{
    class Server
    {
        static Listener l;
        static List<Socket> sockets;
        public static void Main(string[] args)
        {
            serverOpera();
        }
         public static void serverOpera()
        {
            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAcceptedHandler(l_SocketAccepted);
            l.Start();
            Console.Read();
            sockets = new List<Socket>();
        }

        static void l_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Console.WriteLine("New Connection: {0}\n{1}\n=============", e.RemoteEndPoint, DateTime.Now);
            sockets.Add(e);
        }
    }
}
