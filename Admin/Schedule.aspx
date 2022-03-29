<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="Admin_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">View Schedule</h1>
    
    <asp:GridView ID="grdSchedule" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsSchedule" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="ScheduleDate" HeaderText="Setup Date" />
            <asp:BoundField DataField="FlightCode" HeaderText="Setup Date" />
            <asp:BoundField DataField="Departure" HeaderText="Departure" />
            <asp:BoundField DataField="Arrival" HeaderText="Arriaval" />
            <asp:BoundField DataField="Seats" HeaderText="Seats" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsSchedule" runat="server" SelectMethod="Select" 
        TypeName="ScheduleManager"></asp:ObjectDataSource>


</asp:Content>

