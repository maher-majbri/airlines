<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section id="contact-section">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 mb-5 mb-md-0">
                <div class="block">
                    <h2 class="subtitle wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".3s">Contact With Us</h2>
                    <p class="subtitle-des wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".5s">
                       For airline companies, to add flights on our website please contact us to create an account.
                    </p>
                </div>
            </div>
            <div class="col-md-6">
         
            </div>
        </div>
        <div class="row address-details">
            <div class="col-lg-4 col-sm-12">
                <div class="address wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".5s">
                    <i class="ion-ios-location-outline"></i>
                    <p>Benghazi, Taballeno
                        <br />
                        Near Tuskana resturant 
                    </p>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="email wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".7s">
                    <i class="ion-ios-email-outline"></i>
                    <p>support@cieloblu.com<br />info@cieloblu.com</p>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="phone wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".9s">
                    <i class="ion-ios-telephone-outline"></i>
                    <p>+218 444 44 44<br>+218 333 33 33</p>
                </div>
            </div>
        </div>
    </div>
</section>
</asp:Content>

