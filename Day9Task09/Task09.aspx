<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task09.aspx.cs" Inherits="WebApplication1.Task09" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="please select the food items" Font-Size="Larger"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="307px" ImageUrl="~/foodbck.jpg" Width="356px" />
            <br />
            <br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="False">
            <asp:ListItem>BreakFast</asp:ListItem>
            <asp:ListItem>Lunch</asp:ListItem>
            <asp:ListItem>Snacks</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Choose your food" Font-Bold="True" />
    </form>
</body>
</html>
