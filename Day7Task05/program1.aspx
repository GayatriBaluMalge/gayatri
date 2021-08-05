<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program1.aspx.cs" Inherits="WebApplication1.program1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="txt_fname" runat="server" Font-Bold="True" Text="First name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter your name" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="txt_lname" runat="server" Font-Bold="True" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="enter your lastname" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <br />

        </div>
        <asp:Label ID="txt_gender" runat="server" Font-Bold="True" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="transgender" />
        <br />
        <br />
&nbsp;<asp:Label ID="txt_age" runat="server" Font-Bold="True" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="you are not eligible" Font-Bold="True" ForeColor="Red" MaximumValue="35" MinimumValue="18" Type="Integer" ControlToValidate="TextBox3"></asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="txt_state" runat="server" Font-Bold="True" Text="State"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Maharashtra</asp:ListItem>
            <asp:ListItem>tamil nadu</asp:ListItem>
            <asp:ListItem>punjab</asp:ListItem>
            <asp:ListItem>UP</asp:ListItem>
            <asp:ListItem>MP</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Serch" />
        <br />
        <br />
&nbsp;<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit Button" />
&nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
