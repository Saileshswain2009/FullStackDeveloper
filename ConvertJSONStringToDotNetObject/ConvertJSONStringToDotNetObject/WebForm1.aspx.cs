using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;


namespace ConvertJSONStringToDotNetObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string jsonString = "[{\"firstName\":\"SAILESH\",\"lastName\":\"SWAIN\",\"gender\":\"Male\",\"salary\":50000},{\"firstName\":\"SWETA\",\"lastName\":\"BASTIA\",\"gender\":\"Female\",\"salary\":30000}]";
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<Employee> listEmployee=(List<Employee>)javaScriptSerializer.Deserialize(jsonString, typeof(List<Employee>));

            foreach(Employee employee in listEmployee)
            {
                Response.Write("FirstName=" + employee.firstName + "<br/>");
                Response.Write("LastName=" + employee.lastName + "<br/>");
                Response.Write("Gender=" + employee.gender + "<br/>");
                Response.Write("Salary=" + employee.salary + "<br/><br/>");
            }
        }
    }
}