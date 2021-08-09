<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Snacks.aspx.cs" Inherits="WebApplication1.Snacks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> 
                <asp:Image ID="Image1" runat="server" ImageUrl="~/snaks.jpg" />
            </h2>
            <h2> snacks are :</h2>
            <ul>
                <li> crisps</li>
                <li> candy</li>
                <li> biscuits</li>
                <li> chocolate</li>
                <li> fast food</li>

            </ul>
        </div>
    </form>
</body>
</html>
