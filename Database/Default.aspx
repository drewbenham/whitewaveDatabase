<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Database.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Username:&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
<br />
<br />
Password:&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="bnLogin" runat="server" OnClick="bnLogin_Click" Text="Login" />
&nbsp;
</asp:Content>
