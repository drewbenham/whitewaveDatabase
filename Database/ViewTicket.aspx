<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ViewTicket.aspx.cs" Inherits="Database.ViewTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #TextArea1 {
            height: 289px;
            width: 922px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TicketID" DataSourceID="WhiteWaveViewTicket" Width="981px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="TicketID" HeaderText="TicketID" InsertVisible="False" ReadOnly="True" SortExpression="TicketID" />
                <asp:BoundField DataField="TicketName" HeaderText="TicketName" SortExpression="TicketName" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="SupportEvents" HeaderText="SupportEvents" SortExpression="SupportEvents" />
                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                <asp:BoundField DataField="Technician" HeaderText="Technician" SortExpression="Technician" />
                <asp:BoundField DataField="SupportTimer" HeaderText="SupportTimer" SortExpression="SupportTimer" />
                <asp:BoundField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" />
                <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="WhiteWaveViewTicket" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Tickets] WHERE ([TicketID] = ?)">
            <SelectParameters>
                <asp:QueryStringParameter Name="TicketID" QueryStringField="TicketId" Type="Int32" DefaultValue="" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="btnOpen" runat="server" OnClick="btnOpen_Click" Text="Open" />
&nbsp;&nbsp;
        <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="Close" />
    </p>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            <asp:AsyncPostBackTrigger ControlID="btnStart" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnStop" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnReset" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:Label ID="lblTime" runat="server" Font-Size="X-Large" Text="0.0"></asp:Label>
            <br />
            <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" />
            &nbsp;&nbsp;
            <asp:Button ID="btnStop" runat="server" OnClick="btnStop_Click" Text="Stop" />
            &nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
            <br />
            <br />
            Start Time:&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblStart" runat="server" Text="0.0"></asp:Label>
            <br />
            Stop Time:&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblStop" runat="server" Text="0.0"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        Support Event:</p>
&nbsp;<textarea id="TextArea1" name="S1" runat="server"></textarea><br />
    <br />
    <asp:Button ID="btnAddSuppEvent" runat="server" Text="Add Support Event" OnClick="btnAddSuppEvent_Click" />
    &nbsp;&nbsp;
    <br />
</asp:Content>
