<%@ Page Title="" Language="C#" MasterPageFile="~/Company/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Company_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<section id="contact-section">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 mb-md-0">
                <div class="block">
                    <h2 class="subtitle wow fadeInDown" data-wow-duration="500ms" data-wow-delay=".3s">Airline dashboard</h2>
                </div>
            </div>
            <div class="col-md-6">
         
            </div>
        </div>
        <div class="row address-details">
            <div class="col-lg-4 col-sm-12">
                <div class="address wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".5s">
                    <i class="ion-ios-location-outline"></i>
                    <h5>Number of flights flights</h5>
                    <p> 
                        (<asp:Label ID="lblNumberOfFlights" runat="server" Text=""></asp:Label>) Flights.
                    </p>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="email wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".7s">
                    <i class="ion-ios-email-outline"></i>
                    <h5>Number of reservations</h5>
                    <p>
                       (<asp:Label ID="lblNumberOfReservations" runat="server" Text=""></asp:Label>) reservations done so far.
                    </p>
                </div>
            </div>
            <div class="col-lg-4 col-sm-12">
                <div class="phone wow fadeInLeft" data-wow-duration="500ms" data-wow-delay=".9s">
                    <i class="ion-ios-telephone-outline"></i>
                    <h5>Next flights schedule</h5>
                    <p>
                        (<asp:Label ID="lblNumberOfScheduleSetup" runat="server" Text=""></asp:Label>) Flights schedule set up.
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>

</asp:Content>

