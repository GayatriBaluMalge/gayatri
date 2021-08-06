<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task06.aspx.cs" Inherits="WebApplication1.Task06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server" >
        <div>
        </div>
        <asp:Label ID="txt_fname" runat="server" Font-Bold="True" Text="First Name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="txt_lname" runat="server" Font-Bold="True" Text="Last Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="please enter your last name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="txt_age" runat="server" Font-Bold="True" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="you are not eligible" ForeColor="Red" MaximumValue="35" MinimumValue="18" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="txt_gender" runat="server" Font-Bold="True" Text="Gender"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" Text="Male" />
        <asp:RadioButton ID="RadioButton2" runat="server" Font-Bold="True" Text="Female" />
        <asp:RadioButton ID="RadioButton3" runat="server" Font-Bold="True" Text="Transgender" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Marital Status"></asp:Label>
&nbsp;<asp:RadioButton ID="RadioButton4" runat="server" Font-Bold="True" Text="Single" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton5" runat="server" Font-Bold="True" Text="Married" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton6" runat="server" Font-Bold="True" Text="Comited" />
        <br />
        <br />
        <asp:Label ID="txt_email" runat="server" Font-Bold="True" Text="Email Id"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="please enter valid mail id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="txt_pincode" runat="server" Font-Bold="True" Text="Pin Code"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="txt_pwd" runat="server" Font-Bold="True" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Conform_password"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="please enter correct password" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Occupations"></asp:Label>
&nbsp;
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Text="Govt_servent" />
&nbsp;
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Font-Bold="True" Text="Private_job" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Font-Bold="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Bussiness_Man" />
        <br />
        <asp:CheckBox ID="CheckBox4" runat="server" Font-Bold="True" Text="Farmer" />
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
