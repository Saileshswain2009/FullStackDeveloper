<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="MYFirstWebApp_project.Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Height="187px" Width="419px" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="2px" Caption="Registration Form" CellPadding="6" CellSpacing="3" HorizontalAlign="Center">
                <asp:TableRow ID="TableRow1" runat="server">
                    <asp:TableCell ID="TableCell1" runat="server" ForeColor="#0066ff" Font-Bold="true" Font-Size="X-Large" Text="SignUp Here" ColumnSpan="2" HorizontalAlign="Center" VerticalAlign="Middle">

                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ForeColor="#ff6600" Font-Bold="true" Font-Size="Large">Name</asp:TableCell>
                    <asp:TableCell runat="server">
                        
                    
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ForeColor="#ff6600" Font-Bold="true" Font-Size="Large">Password</asp:TableCell>
                    <asp:TableCell runat="server">
                        
                    
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ForeColor="#ff6600" Font-Bold="true" Font-Size="Large">Confirm Password</asp:TableCell>
                    <asp:TableCell runat="server">
                        
                    
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ForeColor="#ff6600" Font-Bold="true" Font-Size="Large">Email</asp:TableCell>
                    <asp:TableCell runat="server">
                        
                    
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ColumnSpan="2" HorizontalAlign="Center" VerticalAlign="Middle">
               
                        <asp:Button ID="Button1" runat="server" Text="Button" ForeColor="#ff6600" Font-Bold="true" Font-Size="Large"/>
                </asp:TableCell>
             </asp:TableRow >
                </asp:Table>
        </div>
    </form>
</body>
</html>
