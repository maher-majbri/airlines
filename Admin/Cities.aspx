<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Cities.aspx.cs" Inherits="Admin_Cities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<h1 class="mt-5 display-6 text-capitalize text-center">Manage Cities</h1>

<asp:TextBox ID="txtID" runat="server" class="form-control" Visible="false" ></asp:TextBox>

    <div class="mb-3">
        <label for="txtName" class="form-label">Name</label>
        <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
    </div>
      <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
      <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click" Enabled="false" />
      <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" Enabled="false" />
      <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click" />
      <br /> 
      <asp:Label ID="lblMessage" runat="server"></asp:Label>

      <hr />

      <asp:GridView ID="GridView1" runat="server" DataSourceID="odsCities" CssClass="table table-bordered" AutoGenerateColumns="False" BorderWidth="0">
          <Columns>
              <asp:BoundField DataField="CityID" HeaderText="ID" />
              <asp:BoundField DataField="CityName" HeaderText="City Name" />
              <asp:HyperLinkField DataNavigateUrlFields="CityID" 
                  DataNavigateUrlFormatString="~/Admin/Cities.aspx?id={0}" HeaderText="Select" 
                  NavigateUrl="~/Admin/Cities.aspx" Text="Edit/Delete" />
          </Columns>
      </asp:GridView>
      <asp:ObjectDataSource ID="odsCities" runat="server" SelectMethod="Select" TypeName="CityManager"></asp:ObjectDataSource>

</asp:Content>

