<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="MYFirstWebApp_project.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Developer:
            <asp:CheckBox ID="CheckBox1" runat="server" SkinID="1" Text="Backend" />

            <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="CheckBox2_CheckedChanged" SkinID="2" Text="Frontend" />

            <asp:CheckBox ID="CheckBox3" runat="server" SkinID="3" Text="Database" />

            <asp:CheckBox ID="CheckBox4" runat="server" SkinID="4" Text="Tester" />
        </div>
    </form>
</body>
</html>
