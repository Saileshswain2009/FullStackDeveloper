using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_project
{
    class ServerOperation
    {
        static byte[] Buffer { get; set; }
        static Socket sck;
        public static void Main(string[] args)
        {
            ServerOperation so = new ServerOperation();
            so.ServerConn();
        }
        public void ServerConn()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));//This socket will bind our socket to a certain end point.
            sck.Listen(100);
            Console.WriteLine("Server is Connected");
            Socket accepted = sck.Accept();//It going to connect a socket which are in waiting state.
            Buffer = new byte[accepted.SendBufferSize];
            int bytesRead = accepted.Receive(Buffer);//wait ,receive and transfer the buffer to Buffer.
            byte[] formatted = new byte[bytesRead];
            for (int i = 0; i < bytesRead; i++)
            {
                formatted[i] = Buffer[i];
            }
            string strData = Encoding.ASCII.GetString(formatted);
            Console.Write(strData + "\r\n");
            Console.Read();
            sck.Close();
            accepted.Close();
        }
    }
}
