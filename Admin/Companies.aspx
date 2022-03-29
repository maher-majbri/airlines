<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Companies.aspx.cs" Inherits="Admin_Companies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     
<h1 class="mt-3 display-6 text-capitalize text-center">Manage Companies</h1>

<asp:TextBox ID="txtID" runat="server" class="form-control" Visible="false" ></asp:TextBox>
 
    
    <div class="mb-3">
        <label for="txtName" class="form-label">Name</label>
        <asp:TextBox ID="txtName" runat="server" class="form-control" 
           ToolTip="Please type the company name" ></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="txtEmail" class="form-label">Email</label>
        <asp:TextBox ID="txtEmail" runat="server" class="form-control" ></asp:TextBox>
    </div>
      <div class="mb-3">
        <label for="txtPassword" class="form-label">Password</label>
        <asp:TextBox ID="txtPassword" runat="server" class="form-control" ></asp:TextBox>
    </div>

    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
    <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click"  Enabled="false"/>
    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click"  Enabled="false"/>
    <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click" />
    <br /> 
    <asp:Label ID="lblMessage" runat="server"></asp:Label>

      <hr />
      <asp:GridView ID="GridView1" runat="server" DataSourceID="odsCompanies" CssClass="table table-bordered"
           AutoGenerateColumns="False" BorderWidth="0">
         <Columns>
              <asp:BoundField DataField="CompanyName" HeaderText="Name" />
              <asp:BoundField DataField="CompanyEmail" HeaderText="Email" />
              <asp:HyperLinkField DataNavigateUrlFields="CompanyID" 
                  DataNavigateUrlFormatString="~/Admin/Companies.aspx?id={0}" HeaderText="Select" 
                  NavigateUrl="~/Admin/Companies.aspx" Text="Edit/Delete" />
          </Columns>
      </asp:GridView>
      <asp:ObjectDataSource ID="odsCompanies" runat="server" SelectMethod="Select" 
          TypeName="CompaniesManager"></asp:ObjectDataSource>


</asp:Content>

