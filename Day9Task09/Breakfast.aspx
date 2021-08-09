<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Breakfast.aspx.cs" Inherits="WebApplication1.Breakfast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <div>
             <h2> &nbsp;</h2>
             <h2> 
                 <asp:Image ID="Image1" runat="server" ImageUrl="~/foods.jpg" />
             </h2>
             <h2> &nbsp;</h2>
             <h2> BreakFast Menu :</h2>
             <p> &nbsp;</p>
            <ul>
                <li> poha</li>
                <li> idli</li>
                <li> uttapam</li>
                <li> momoes</li>
                <li> upama</li>

            </ul>
        </div>
    </form>
</body>
</html>
