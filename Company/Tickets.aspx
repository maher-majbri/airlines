<%@ Page Title="" Language="C#" MasterPageFile="~/Company/MasterPage.master" AutoEventWireup="true" CodeFile="Tickets.aspx.cs" Inherits="Company_Tickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">Edit Tickets</h1>
    <p class="text-center">Add, edit or delete your tickets</p>

    <asp:GridView ID="grdTickets" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsTickets" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="TicketCode" HeaderText="Setup Date" />
            <asp:HyperLinkField DataNavigateUrlFields="ScheduleID" 
                  DataNavigateUrlFormatString="~/Company/Tickets.aspx?id={0}" HeaderText="Select" 
                  NavigateUrl="~/Company/Tickets.aspx" Text="Edit/Delete" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsTickets" runat="server" SelectMethod="Select" 
        TypeName="TicketsManager"></asp:ObjectDataSource>

</asp:Content>

