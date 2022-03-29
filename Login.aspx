<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="contact-section">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mb-5 mb-md-0">
                <div class="block">
                    <h2 class="subtitle wow fadeInDown mt-5" data-wow-duration="500ms" data-wow-delay=".3s">Members Login</h2>
                    <p class="subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s">
                        If you have an account, you can enter your email and password to login.
                    <br />
                        You can Register new account from <a href="Register.aspx">Create Account</a> page.
                    </p>

                    <div class="contact-form">
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".8s">
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="Your Email" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                 <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control" placeholder="Your Password"  ></asp:TextBox>
                            </div>
                            <div  class="mb-3">
                                   <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                            </div>
                            <div id="submit" class="wow fadeInDown">
                                   <asp:Button ID="btnLogin" runat="server" Text="Login"  class="btn btn-default btn-send hvr-bounce-to-right"  data-wow-duration="500ms" data-wow-delay="1.4s" OnClick="btnLogin_Click" />
                            </div>                      
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                
            </div>
        </div>
    </div>
</section>  

 

</asp:Content>

