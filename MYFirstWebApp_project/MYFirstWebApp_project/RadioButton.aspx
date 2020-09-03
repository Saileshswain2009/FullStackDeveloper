<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="MYFirstWebApp_project.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Maritail Status:
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" BackColor="Yellow" BorderColor="#66FF33" BorderWidth="10px" Checked="True" Font-Bold="True" Font-Italic="True" Font-Names="Magneto" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="True" ForeColor="Red" GroupName="status" Height="30px" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Single" TextAlign="Left" ToolTip="Single" />

            <asp:RadioButton ID="RadioButton2" runat="server" BackColor="Yellow" BorderColor="#66FF33" BorderWidth="10px" Font-Bold="True" Font-Italic="True" Font-Names="Magneto" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="True" ForeColor="Red" GroupName="status" Height="30px" Text="Married" TextAlign="Left" ToolTip="Married" />

            <asp:RadioButton ID="RadioButton3" runat="server" BackColor="Yellow" BorderColor="#66FF33" BorderWidth="10px" Font-Bold="True" Font-Italic="True" Font-Names="Magneto" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="True" ForeColor="Red" GroupName="status" Height="30px" Text="Unknow" TextAlign="Left" ToolTip="Unknow" />

        </div>
    </form>
</body>
</html>
