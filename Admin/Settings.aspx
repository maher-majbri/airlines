<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Admin_Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section id="contact-section">
    <div class="container">
        <h2 class="text-center subtitle wow fadeInDown mt-5" data-wow-duration="500ms" data-wow-delay=".3s">Member's settings</h2>
        <p class="text-center subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s"> 
            Edit profile or update your password.
        </p>
        <div class="row">
            <div class="col-md-4 offset-1  mb-5">
                <div class="contact-form">
                    <h5>Edit Profile</h5>
                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                        <asp:TextBox ID="txtName" runat="server" placeholder="Your Name" class="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".8s">
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Your Email" class="form-control" ></asp:TextBox>
                    </div>
                    <div id="submit" class="wow fadeInDown">
                        <asp:Button ID="btnSave" runat="server" Text="Update Profile"   class="btn btn-default btn-send hvr-bounce-to-right"  data-wow-duration="500ms" data-wow-delay="1.4s" OnClick="btnSave_Click" />
                        <asp:Label ID="lblMessage1" runat="server"></asp:Label>
                    </div>                      
                </div>
            </div>
            <div class="col-md-4 offset-1 mb-5">
                <div class="contact-form">
                    <h5>Update your password</h5>
                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                        <asp:TextBox ID="txtOldPassword" TextMode="Password" runat="server" class="form-control" placeholder="Your Old Password"  ></asp:TextBox>
                    </div>
                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                        <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server" class="form-control" placeholder="Your New Password"  ></asp:TextBox>
                    </div>
                    <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                        <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" class="form-control" placeholder="Confirm Password"  ></asp:TextBox>
                    </div>
                    <div  class="mb-3">
                            <asp:Label ID="lblMessage2" runat="server" Text=""></asp:Label>
                    </div>
                    <div id="submit" class="wow fadeInDown">
                        <asp:Button ID="btnUpdatePassword" runat="server" Text="Update Password"  class="btn btn-default btn-send hvr-bounce-to-right"  data-wow-duration="500ms" data-wow-delay="1.4s" OnClick="btnUpdatePassword_Click" />
                    </div>                      
                </div>

            </div>
        </div>
    </div>
</section>  

</asp:Content>

