<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="MYFirstWebApp_project.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="UploadFile" OnClick="Button1_Click" />
    </form>
</body>
</html>
