using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYFirstWebApp_project
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem li = new ListItem("Africa", "10");
                DropDownList1.Items.Add(li);
            }
        }

        protected void DropDownList1_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Value;
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Hello to my country!");
        }
    }
}