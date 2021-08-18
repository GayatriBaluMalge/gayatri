<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program1.aspx.cs" Inherits="Task18.program1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>CourseWare FeedBack Form</h2>
            <p>&nbsp;</p>
            <p>
                <asp:Label ID="txt_name" runat="server" Font-Bold="True" Text="Name"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Sex"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" Text="Male" />
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Font-Bold="True" Text="Female" />
            </p>
        </div>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Select Course"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>DotNet</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>Angular</asp:ListItem>
            <asp:ListItem>python</asp:ListItem>
            <asp:ListItem>SQL</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Technical Coverage"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Excellent</asp:ListItem>
            <asp:ListItem>Good</asp:ListItem>
            <asp:ListItem>Poor</asp:ListItem>
            <asp:ListItem>Average</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Suggestions"></asp:Label>
        <p>
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea></p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Form" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
