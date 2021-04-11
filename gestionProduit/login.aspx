<%@ Page Title="" Language="C#" MasterPageFile="~/first.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="gestionProduit.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><h1>Log in</h1><br />
    <table style="width:100%; text-align:left;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Log in" CssClass="btn btn-success" style="color:white;" OnClick="login_click"/>
            </td>
            
        </tr>
    </table>
    <br />
    <asp:Label ID="notfound" runat="server" Text="Label" Visible="False" CssClass="alert alert-info"></asp:Label>
</asp:Content>
