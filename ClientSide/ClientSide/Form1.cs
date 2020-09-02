using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace ClientSide
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 8888);//To get the server and read the msg.
            NetworkStream ns = client.GetStream();//To get the server stream(NetworkStream)
            StreamReader sr = new StreamReader(ns);

            txtServerMessage.Text = "Server>>" + sr.ReadLine();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text!="")
            {
                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(txtMessage.Text);
                sw.Flush();
                sw.Close();
                ns.Close();
            }
        }

        private void txtServerMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
