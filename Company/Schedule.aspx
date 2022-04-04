<%@ Page Title="" Language="C#" MasterPageFile="~/Company/MasterPage.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="Company_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">Edit Schedule</h1>
    <p class="text-center">Add, edit or delete your schedule</p>
  
    <asp:TextBox ID="txtID" runat="server" class="form-control" Visible="false" ></asp:TextBox>
   
    
      <div class="mb-3">
        <label for="ddlFlight" class="form-label">Flight Code</label>
           <asp:DropDownList ID="ddlFlight" runat="server"  class="form-select form-control" DataSourceID="odsFlights" 
               DataTextField="FlightCode" DataValueField="FlightID" ></asp:DropDownList>
            <asp:ObjectDataSource ID="odsFlights" runat="server" SelectMethod="SelectByCompany" 
                TypeName="FlightsManager">
                <SelectParameters>
                    <asp:SessionParameter Name="company_id" SessionField="CompanyID" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
      </div>
      <div class="mb-3">
          <label for="txtSeats" class="form-label">Seats</label>
          <asp:TextBox ID="txtSeats" runat="server" CssClass="form-control"></asp:TextBox>
      </div>
      <div class="mb-3 row">
          <div class="col-md-6">
            <label for="txtTo" class="form-label">Departure Date</label>
            <asp:Calendar ID="cdrDeparture" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="cdrDeparture_SelectionChanged" Width="220px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
          </div>
          <div class="col-md-6">
              <label for="txtTo" class="form-label">Arrival Date</label>
            <asp:Calendar ID="cdrArrival" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="cdrArrival_SelectionChanged" Width="220px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
          </div>
      </div> 
       
      <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
      <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click"  Enabled="false" />
      <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click"  Enabled="false" />
      <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click" />
      <br /> 
    <asp:Label ID="lblMessage" runat="server"></asp:Label>

      <hr />
    
    <asp:GridView ID="grdSchedule" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0"
        DataSourceID="odsSchedule" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="ScheduleDate" HeaderText="Setup Date" />
            <asp:BoundField DataField="FlightCode" HeaderText="Setup Date" />
            <asp:BoundField DataField="Departure" HeaderText="Departure" />
            <asp:BoundField DataField="Arrival" HeaderText="Arriaval" />
            <asp:BoundField DataField="Seats" HeaderText="Seats" />
            <asp:HyperLinkField DataNavigateUrlFields="ScheduleID" 
                  DataNavigateUrlFormatString="~/Company/Schedule.aspx?id={0}" HeaderText="Select" 
                  NavigateUrl="~/Company/Schedule.aspx" Text="Edit/Delete" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsSchedule" runat="server" SelectMethod="Select" 
        TypeName="ScheduleManager"></asp:ObjectDataSource>

</asp:Content>

