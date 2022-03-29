<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Flights.aspx.cs" Inherits="Admin_Flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">View Flights</h1>

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsTickets" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
            <asp:BoundField DataField="FromCity" HeaderText="From" />
            <asp:BoundField DataField="ToCity" HeaderText="To" />
            <asp:BoundField DataField="FlightPrice" HeaderText="Price" />
            <asp:BoundField DataField="FlightClass" HeaderText="Class" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsTickets" runat="server" SelectMethod="Select" 
        TypeName="FlightsManager"></asp:ObjectDataSource>
   


</asp:Content>

