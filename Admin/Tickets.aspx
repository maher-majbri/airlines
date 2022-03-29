<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Tickets.aspx.cs" Inherits="Admin_Tickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">View Tickets</h1>
   
    <asp:GridView ID="grdTickets" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsTickets" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="TicketCode" HeaderText="Code" />
            <asp:BoundField DataField="FlightCode" HeaderText="Reservation Date" />
            <asp:BoundField DataField="MemberName" HeaderText="Member Name" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsTickets" runat="server" SelectMethod="Select" 
        TypeName="TicketsManager"></asp:ObjectDataSource>

</asp:Content>

