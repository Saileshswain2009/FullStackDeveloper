<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MYFirstWebApp_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
           <b> Hello </b><br/>
            <strong> Ausotosh </strong>
            <strong> Gaurav </strong>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine" Text="enter your name" ReadOnly="false" AutoPostBack="true"
                BackColor="#ff3300" BorderStyle="Dotted" BorderWidth="3px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
