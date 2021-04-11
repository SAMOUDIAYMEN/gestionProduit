<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="gestionProduit.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center;">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </h1>
    </div>
    <div style="text-align:center;">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Buy nom" />
    </div>
</asp:Content>
