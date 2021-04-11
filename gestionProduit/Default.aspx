<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gestionProduit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align:center;">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </h1>
    </div>
    <asp:GridView  ID="GridView1" runat="server" CssClass="table table-responsive" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/products.aspx?id={0}" DataTextField="categoryName" HeaderText="categoryName" NavigateUrl="~/products.aspx" Text="categoryName" />
            </Columns>
        </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [categoryName], [Id] FROM [categories]"></asp:SqlDataSource>

</asp:Content>
