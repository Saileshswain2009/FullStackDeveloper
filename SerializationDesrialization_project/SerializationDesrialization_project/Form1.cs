using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace SerializationDesrialization_project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            per.Id = 1;
            per.Name = "SAILESH";
            per.Email = "Saileshswain2010@gmail.com";

            MemoryStream ms = new MemoryStream();
            DataContractJsonSerilaizer ser = new DataContractJsonSerilaizer(typeof(Person));
            ser.WriteObject(ms, per);
            byte[] jsonArray = ms.ToArray();
            string str = Encoding.UTF8.GetString(jsonArray);
            rtbSerialize.Text = str;
        }
    }
}
