using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration.Assemblies;

namespace ConnectionStringInADO.Net
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Connection successful");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
