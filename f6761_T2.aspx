<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f6761_T2.aspx.cs" Inherits="f6761_T2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Yhteensä maita: "></asp:Label><asp:Label ID="txtMaat" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Asukasluku: "></asp:Label><asp:Label ID="txtAsukasluku" runat="server" Text="Label"></asp:Label> <br />
        
        <asp:Button ID="btnKaikki" runat="server" Text="Näytä Kaikki" OnClick="btnKaikki_Click" /><asp:Button ID="btnSuurimmat" runat="server" Text="10 Suurinta" OnClick="btnSuurimmat_Click" /><asp:Button ID="btnElinAika" runat="server" Text="Elinajanodote pienin" OnClick="btnElinAika_Click" />
        <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="txtSearch_TextChanged"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="Haku" OnClick="btnSearch_Click" /> <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Countries.xml"></asp:XmlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Nimi" DataField="Name" />
                <asp:BoundField HeaderText="Maanosa" DataField="Continent" />
                 <asp:BoundField HeaderText="Asukasluku" DataField="Population" />
                 <asp:BoundField HeaderText="Paikallinen nimi" DataField="LocalName" />
                 <asp:BoundField HeaderText="Maan Johtaja" DataField="HeadOfState" />
            </Columns>
            
        </asp:GridView>
        
    </div>
        <asp:Label ID="txtError" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
