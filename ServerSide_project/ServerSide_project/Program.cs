using System;
using System.Net.Sockets;
using System.IO;

namespace ServerSide_project
{
    class SocketOperation
    {
        public static void Main(string[] args)
        {
            SocketOperation s = new SocketOperation();
            s.MyMethod();
        }
        public void MyMethod()
        {
            TcpListener server = new TcpListener(8888);//creation of server.
            server.Start();
            Console.WriteLine("Srever Started and waiting for clents");

            Socket socketForClients = server.AcceptSocket();//waiting for clents.Socket is basically made for communicate diff. clients.
            if (socketForClients.Connected)//If any server connects with clients then this socket works
            {
                //Send message to client
                NetworkStream ns = new NetworkStream(socketForClients);//Making virtual file in network.
                StreamWriter sw = new StreamWriter(ns); //Server send msg to client.ns:-is a file of network path.vitrual path.
                Console.WriteLine("Server said Welcome Client");
                sw.WriteLine("Welcome Client");//sending msg to client and write in virtual file.
                sw.Flush();//To push the msg to the server stream.
                //Get message to client
                try
                {
                    StreamReader sr = new StreamReader(ns);
                    Console.WriteLine("Client>>" + sr.ReadLine());
                    sw.Close();
                    ns.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            socketForClients.Close();
        }
    }
}
