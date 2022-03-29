<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<section id="contact-section">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mb-5 mb-md-0">
                <div class="block">
                    <h2 class="subtitle wow fadeInDown mt-5" data-wow-duration="500ms" data-wow-delay=".3s">Member Registration</h2>
                    <p class="subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s">
                        Please fill this form to creat membership account.
                    <br />
                        Allready have an account? Go to login <a href="Login.aspx">page</a>.
                    </p>

                    <div class="contact-form">
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                <asp:TextBox ID="txtName" runat="server" placeholder="Your Name" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".8s">
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="Your Email" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                 <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control" placeholder="Your Password"  ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                <asp:TextBox ID="txtConfirmPassword" placeholder="Confirm Password" TextMode="Password" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                <asp:TextBox ID="txtPhone" runat="server" placeholder="Your Phone" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group wow fadeInDown" data-wow-duration="500ms" data-wow-delay="1s">
                                <label for="txtPhone" class="form-label">City</label>
                                <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-select form-control" DataSourceID="odsCity" DataTextField="CityName" DataValueField="CityID"></asp:DropDownList>
                                <asp:ObjectDataSource ID="odsCity" runat="server" SelectMethod="Select" TypeName="CityManager"></asp:ObjectDataSource>
                            </div>
                            <div  class="mb-3">
                                   <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </div>
                            <div id="submit" class="wow fadeInDown">
                                    <asp:Button ID="btnRegister" runat="server" Text="Register"   class="btn btn-default btn-send hvr-bounce-to-right"  data-wow-duration="500ms" data-wow-delay="1.4s" OnClick="btnRegister_Click" />
                                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
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

