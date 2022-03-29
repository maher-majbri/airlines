<%@ Page Title="" Language="C#" MasterPageFile="~/Company/MasterPage.master" AutoEventWireup="true" CodeFile="Flights.aspx.cs" Inherits="Company_Flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1 class="mt-5 display-6 text-capitalize text-center">Edit Flights</h1>
    <p class="text-center">Add, edit or delete your flights</p>

    <div class="mb-3">
      <label for="txtCode" class="form-label">Flight Code</label>
        <asp:TextBox ID="txtCode" runat="server" class="form-control" ></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="txtFrom" class="form-label">From</label>
           <asp:DropDownList ID="ddlFrom" runat="server"  class="form-select form-control" DataSourceID="odsCityFrom" 
               DataTextField="CityName" DataValueField="CityID" ToolTip="Please choose City"></asp:DropDownList>
           <asp:ObjectDataSource ID="odsCityFrom" runat="server" SelectMethod="Select" 
            TypeName="CityManager"></asp:ObjectDataSource>
      </div>

      <div class="mb-3">
        <label for="txtTo" class="form-label">To</label>
          <asp:DropDownList ID="ddlTo" runat="server" class="form-select form-control" DataSourceID="odsCityTo" 
              DataTextField="CityName" DataValueField="CityID" ToolTip="Please choose City"></asp:DropDownList>
           <asp:ObjectDataSource ID="odsCityTo" runat="server" SelectMethod="Select" 
            TypeName="CityManager"></asp:ObjectDataSource>
          </div> 
      <div class="mb-3">
        <label for="txtPrice" class="form-label">Price</label>
          <asp:TextBox ID="txtPrice" runat="server" class="form-control" ></asp:TextBox>
      </div>
      <div class="mb-3">
        <label for="txtClass" class="form-label">Class</label>
          <asp:DropDownList ID="ddlClass" runat="server" class="form-select form-control" 
              ToolTip="Please choose Class">
              <asp:ListItem>ECO</asp:ListItem>
              <asp:ListItem>BUS</asp:ListItem>
              <asp:ListItem>FIR</asp:ListItem>
          </asp:DropDownList>
      </div>
       
      <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
      <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click"  Enabled="false" />
      <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click"  Enabled="false" />
      <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click" />
      <br /> 
    <asp:Label ID="lblMessage" runat="server"></asp:Label>

      <hr />

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0px"
        DataSourceID="odsTickets" ToolTip="Please choose Class">
        <Columns>
            <asp:BoundField DataField="FromCity" HeaderText="From" />
            <asp:BoundField DataField="ToCity" HeaderText="To" />
            <asp:BoundField DataField="FlightPrice" HeaderText="Price" />
            <asp:BoundField DataField="FlightClass" HeaderText="Class" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsTickets" runat="server" SelectMethod="SelectByCompany" 
        TypeName="FlightsManager">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="1" Name="company_id" SessionField="CompanyID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
   


</asp:Content>

