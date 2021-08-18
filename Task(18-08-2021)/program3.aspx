<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program3.aspx.cs" Inherits="Task18.program3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3> Web Controls</h3>
            <p> &nbsp;</p>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Hello"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Click Me" />
    </form>
</body>
</html>
