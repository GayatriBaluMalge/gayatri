<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program6and7.aspx.cs" Inherits="Task18.program6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Soap</asp:ListItem>
            <asp:ListItem>Lipstick</asp:ListItem>
            <asp:ListItem>Shampoo</asp:ListItem>
            <asp:ListItem>Facewash</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="400px" OnClick="ImageButton1_Click" Width="400px" />
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Enter the Quantity"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txt_qtn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calculate Quantity" />
        <br />
        <br />
        <asp:Label ID="txt_quantity" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
