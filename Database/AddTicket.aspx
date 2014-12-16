<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddTicket.aspx.cs" Inherits="Database.AddTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Ticket Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTicketName" runat="server" Width="292px"></asp:TextBox>
    </p>
    Problem Description:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtProbDescrip" runat="server" style="margin-left: 0px" Width="794px"></asp:TextBox>
    <br />
    <br />
    Priority:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddPriority" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    Technician Assigned:&nbsp;&nbsp; <asp:TextBox ID="txtTechAssign" runat="server" Width="287px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCreateTicket" runat="server" Text="Create Ticket" OnClick="btnCreateTicket_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancelTicketCreation" runat="server" Text="Cancel" OnClick="btnCancelTicketCreation_Click1" />
</asp:Content>
