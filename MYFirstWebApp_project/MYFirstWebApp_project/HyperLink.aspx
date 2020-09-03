<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLink.aspx.cs" Inherits="MYFirstWebApp_project.HyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="75px" ImageUrl="~/Images/download.jpg" ImageWidth="130px" NavigateUrl="https://www.google.com" Target="_blank">Click Here</asp:HyperLink>
        </div>
    </form>
</body>
</html>
