<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="gestionProduit.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center;">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </h1>
    </div>
    <asp:GridView ID="GridView1"  CssClass="table table-responsive"  runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/Basket.aspx?id={0}" DataTextField="productName" HeaderText="productName" NavigateUrl="~/Basket.aspx" Text="productName" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [products] WHERE ([categoryID] = @categoryID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="categoryID" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
