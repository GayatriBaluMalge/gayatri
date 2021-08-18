<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program2.aspx.cs" Inherits="Task18.program2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<div>
            <h3>Click any of the image to display it at the bottom</h3>
            <h4>Click on the image at bottom to clear it</h4>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1"  src="circle.png" runat="server" Height="116px" Width="133px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" src="rec.png" runat="server" Height="118px" Width="148px" OnClick="ImageButton2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" src="tri.png" runat="server" Height="115px" Width="137px" OnClick="ImageButton3_Click" />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton4" runat="server" AlternateText="Click a image " BorderColor="White" BorderStyle="None" Height="128px" OnClick="ImageButton4_Click" Width="174px" />
        </div>
        </div>
&nbsp;
        &nbsp;
        <br />
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
