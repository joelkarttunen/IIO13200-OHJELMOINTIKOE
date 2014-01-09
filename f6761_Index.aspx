<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f6761_Index.aspx.cs" Inherits="f6761_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>.NET Ohjelmointikoe Joel Karttunen F6761</h2>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Img/18983_4126405716946_771599386_n.jpg" Height="400px" Width="300px" /> <br>

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/f6761_T2.aspx">Tehtävä 2</asp:HyperLink> <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/f6761_T3.aspx">Tehtävä 3</asp:HyperLink> <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/f6761_Pisteet.aspx">Pisteet ja palaute</asp:HyperLink> <br />

        
    </div>
    </form>
</body>
</html>
