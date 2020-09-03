<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Button.aspx.cs" Inherits="MYFirstWebApp_project.Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server">message</asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="change" OnClick="Button1_Click" OnClientClick="alert(&quot;You have won Rs:-20000&quot;)" PostBackUrl="~/CheckBox.aspx" />
        </div>
    </form>
</body>
</html>
