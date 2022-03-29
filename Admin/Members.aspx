<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Members.aspx.cs" Inherits="Admin_Members" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<h1 class="mt-5 display-6 text-capitalize text-center">Manage Memebers</h1>
 
<asp:TextBox ID="txtID" runat="server" class="form-control" Visible="false" ></asp:TextBox>
 
    <div class="mb-3">
        <label for="txtName" class="form-label">Name</label>
        <asp:TextBox ID="txtName" runat="server" class="form-control" ></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="txtEmail" class="form-label">Email</label>
        <asp:TextBox ID="txtEmail" runat="server" class="form-control" ></asp:TextBox>
    </div>
      <div class="mb-3">
        <label for="txtPhone" class="form-label">Phone</label>
        <asp:TextBox ID="txtPhone" runat="server" class="form-control" ></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="txtPassword" class="form-label">Password</label>
        <asp:TextBox ID="txtPassword" runat="server" class="form-control" ></asp:TextBox>
    </div>
      <div class="mb-3">
        <label for="txtCity" class="form-label">City</label>
          <asp:DropDownList ID="ddlCity" runat="server" class="form-select form-control" DataSourceID="odsCities" DataTextField="CityName" DataValueField="CityID"  >
          </asp:DropDownList>
          <asp:ObjectDataSource ID="odsCities" runat="server" SelectMethod="Select" TypeName="CityManager"></asp:ObjectDataSource>
    </div>
    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
      <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click"  Enabled="false" />
      <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click"  Enabled="false" />
      <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click" />
      <br /> 
      <asp:Label ID="lblMessage" runat="server"></asp:Label>

      

      <hr />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" DataSourceID="odsMemebers" BorderWidth="0">
          <Columns>
              <asp:BoundField DataField="MemberName" HeaderText="Name" />
              <asp:BoundField DataField="MemberEmail" HeaderText="Email" />
              <asp:BoundField DataField="MemberPhone" HeaderText="Phone" />
              <asp:BoundField DataField="CityName" HeaderText="City" />
              <asp:HyperLinkField DataNavigateUrlFields="MemberID" 
                  DataNavigateUrlFormatString="~/Admin/Members.aspx?id={0}" HeaderText="Select" 
                  NavigateUrl="~/Admin/Members.aspx" Text="Edit/Delete" />
          </Columns>
    </asp:GridView>
      <asp:ObjectDataSource ID="odsMemebers" runat="server" SelectMethod="Select" 
          TypeName="MemberManager"></asp:ObjectDataSource>
    
</asp:Content>

