<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lunch.aspx.cs" Inherits="WebApplication1.Lunch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:bisque">
    <form id="form1" runat="server">
        <div>
             <h2> &nbsp;</h2>
             <h2> 
                 <asp:Image ID="Image1" runat="server" ImageUrl="~/lunch.jpg" />
             </h2>
             <h2> Lunch  Menus are :</h2>
            <ul>
                <li> panner masala</li>
                <li> butter chicken</li>
                <li> palak paneer</li>
                <li> daal fry</li>
                <li> mix veg</li>

            </ul>
        </div>
    </form>
</body>
</html>
