<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="MYFirstWebApp_project.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 143px; width: 943px">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="115px" OnCallingDataMethods="DropDownList1_CallingDataMethods" OnTextChanged="DropDownList1_TextChanged" style="margin-left: 0px" Width="122px">
                <asp:ListItem Selected="True">Choose yor country</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>England</asp:ListItem>
                <asp:ListItem>South Africa</asp:ListItem>
                <asp:ListItem>New Zeland</asp:ListItem>
                <asp:ListItem>Sri Lanka</asp:ListItem>
                <asp:ListItem>Bangladesh</asp:ListItem>
                <asp:ListItem>Hungry</asp:ListItem>
                <asp:ListItem>Paris</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
