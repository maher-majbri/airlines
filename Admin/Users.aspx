<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Admin_Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<h1 class="mt-5 display-6 text-capitalize text-center">Manage Users</h1>

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
        <label for="txtPassword" class="form-label">Password</label>
        <asp:TextBox ID="txtPassword" runat="server" class="form-control" 
            ></asp:TextBox>
    </div>
      <div class="mb-3">
        <label for="txtUsersType" class="form-label">User Type</label>

          <asp:DropDownList ID="ddlType" runat="server" CssClass="form-control form-select">
              <asp:ListItem>Admin</asp:ListItem>
              <asp:ListItem>User</asp:ListItem>
          </asp:DropDownList>
    </div>
      
    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
    <asp:Button ID="btnSave" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" Enabled="false"  />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" Enabled="false"  />
    <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-primary" OnClick="btnClear_Click"  />
    <br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>

      <hr />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" DataSourceID="odsUsers" BorderWidth="0px">
          <Columns>
              <asp:BoundField DataField="UserName" HeaderText="Name" />
              <asp:BoundField DataField="UserEmail" HeaderText="Email" />
              <asp:HyperLinkField DataNavigateUrlFields="UserId" DataNavigateUrlFormatString="~/Admin/Users.aspx?id={0}" HeaderText="Edit" NavigateUrl="~/Admin/Users.aspx" Text="Edit" />
          </Columns>
    </asp:GridView>
      <asp:ObjectDataSource ID="odsUsers" runat="server" SelectMethod="Select" 
          TypeName="UsersManager"></asp:ObjectDataSource>
   
      <asp:ObjectDataSource ID="odsMemebers" runat="server" SelectMethod="Select" 
          TypeName="MemberManager"></asp:ObjectDataSource>
    
</asp:Content>

