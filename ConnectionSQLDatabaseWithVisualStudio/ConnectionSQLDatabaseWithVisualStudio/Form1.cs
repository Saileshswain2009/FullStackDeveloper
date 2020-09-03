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

namespace ConnectionSQLDatabaseWithVisualStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=employee_db";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q="insert into Test(id,name)values('"+txtID.Text.ToString()+"','"+txtName.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made Successfully...!");
            }
        }
    }
}
