<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f6761_T3.aspx.cs" Inherits="f6761_T3" MasterPageFile="~/f6761_T3Master.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" EnableViewState="true">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Demox %>" SelectCommand="SELECT * FROM [asiakas] ORDER BY asnimi"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Demox %>" SelectCommand="SELECT astunnus, asnimi, yhteyshlo, maa FROM [asiakas] ORDER BY asnimi"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Demox %>" SelectCommand="SELECT astunnus, asnimi, ostot FROM [asiakas] WHERE ostot IS NOT NULL ORDER BY ostot"></asp:SqlDataSource>
        
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" EnableViewState="true" AutoPostBack="true" > </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Asiakkaat lkm: "></asp:Label>
        <asp:Label ID="txtLkm" runat="server" Text="Label"></asp:Label> <br />
        <asp:Label ID="Label2" runat="server" Text="Ostosten lkm: "></asp:Label><asp:Label ID="txtOstosLkm" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Ostosten arvo: "></asp:Label><asp:Label ID="txtOstosArvo" runat="server" Text="Label"></asp:Label> <br />
        <asp:Label ID="txtError" runat="server" Text=""></asp:Label>
    <br />
        <asp:Button ID="btnGetAll" runat="server" Text="Hae kaikki asiakkaat" OnClick="btnGetAll_Click" /><asp:Button ID="btnOstos" runat="server" Text="Ostoksia omaavat" OnClick="btnOstos_Click" />
        <asp:TextBox ID="txtSearch" runat="server" EnableViewState="true"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="Hae" OnClick="btnSearch_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
</asp:Content>


    
    
    
        
 