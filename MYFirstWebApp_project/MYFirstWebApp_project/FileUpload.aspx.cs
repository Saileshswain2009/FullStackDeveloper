using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace MYFirstWebApp_project
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFiles)
            {
                string fileExt = Path.GetExtension(FileUpload1.FileName);
                if (fileExt.ToLower() == ".jpg")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/FilesUploaded/" + FileUpload1.FileName));
                    Response.Write("<h1>Uploaded Successfully</h1>");
                }
                else
                {
                    Response.Write("<h1>Atleast Upload one image File</h1>");
                }
            }
            else
            {
                Response.Write("Please select a file");
            }
            
        }
    }
}