using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace MultiConnSocket_project
{
    class ServerOperation
    {
        static Listener l;
        static List<Socket> sockets;
        public static void Main(string[] args)
        {
            ServerOperation so = new ServerOperation();
            so.ListenerOperation();
        }
         public void ListenerOperation()
        {
            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAccetedHandler(l_SocketAccepted);
            l.Start();
            sockets = new List<Socket>();
            Console.Read();
        }
        static void l_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Console.WriteLine("New Connection: {0}\n{1}\n=========", e.RemoteEndPoint, DateTime.Now);//I.p Address of the Endpoint & current time to the console.
            sockets.Add(e);
        }
    }
}
