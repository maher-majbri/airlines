<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Reservations.aspx.cs" Inherits="Admin_Reservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">View Reservations</h1>

    <asp:GridView ID="grdReservations" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsReservations" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="ReservationDate" HeaderText="Date and Time" />
            <asp:BoundField DataField="MemberName" HeaderText="Customer" />
            <asp:BoundField DataField="Departure" HeaderText="Departure Time" />
            <asp:BoundField DataField="Arrival" HeaderText="Arrival Time" />
            <asp:BoundField DataField="Adults" HeaderText="Number of Adults" />
            <asp:BoundField DataField="Children" HeaderText="Number of Children" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsReservations" runat="server" SelectMethod="Select" 
        TypeName="ReservationsManager"></asp:ObjectDataSource>


</asp:Content>

