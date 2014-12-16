<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="Database.MyAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Name:
        Drew Benham</p>
<p>
    Username: drew</p>
<p>
    Password:
    1234</p>
<p>
    Email: drewbenham@yahoo.com</p>
<p>
    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register New User" />
</p>
</asp:Content>
