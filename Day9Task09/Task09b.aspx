<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task09b.aspx.cs" Inherits="WebApplication1.Task09b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Gold</asp:ListItem>
                        <asp:ListItem>Silver</asp:ListItem>
         </asp:ListBox>
                    
     
                 
                    <br />
                    <asp:Button Class="btn btn-primary" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />
         <br />
         <br />
    </form>
</body>
</html>
