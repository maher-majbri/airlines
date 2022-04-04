<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <!--
==================================================
Slider Section Start
================================================== -->
<section id="hero-area" >
<div class="container">
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="block wow fadeInUp" data-wow-delay=".3s">
                
                <!-- Slider -->
                <section class="cd-intro"">

                       <div>
                <div class="row">
                    <div class="col-lg-3">
                        <label>Departure Place</label>
                        <asp:DropDownList ID="ddlDeparture" runat="server" class="form-control" DataSourceID="odsDeparture" DataTextField="CityName" DataValueField="CityID"></asp:DropDownList>
                        <asp:ObjectDataSource ID="odsDeparture" runat="server" SelectMethod="Select" TypeName="CityManager"></asp:ObjectDataSource>
                    </div>
                    <div class="col-lg-3">
                        <label>Arrival Place</label>
                        <asp:DropDownList ID="ddlArrival" runat="server" class="form-control" DataSourceID="odsArrival" DataTextField="CityName" DataValueField="CityID"></asp:DropDownList>
                        <asp:ObjectDataSource ID="odsArrival" runat="server" SelectMethod="Select" TypeName="CityManager"></asp:ObjectDataSource>
                   </div>
                    <div class="col-lg-3">
                        <label>Date of Departure</label>
                        <asp:TextBox ID="txtDateDeparture" runat="server" CssClass="form-control"></asp:TextBox>
                        <p id="DepartureDateToggle">Choose date of departure...</p>
                        <div id="DepartureDate">
                            <asp:Calendar ID="cdrDeparture" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="cdrDeparture_SelectionChanged" Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <label>Date of Arrival</label>
                        <asp:TextBox ID="txtDateArrival" runat="server" CssClass="form-control"></asp:TextBox>
                        <p id="ArrivalDateToggle">Choose date of arrival...</p>
                    <div id="ArrivalDate">
                            <asp:Calendar ID="cdrArrival" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="cdrArrival_SelectionChanged" Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                    </div>

                    </div>
                    <div class="col-lg-4">
                        <h3><label>Number of Passengers</label></h3>
                        <label>Adults</label>
                        <asp:DropDownList ID="ddlAdults" runat="server" CssClass="form-control form-select">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-4">
                        <label class="mt-5">Children</label>
                        <asp:DropDownList ID="ddlChildren" runat="server" CssClass="form-control form-select">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-4">

                    </div>
                    <div class="col-12">
                        <asp:Button ID="btnSearch" runat="server" Text="Search Flights" CssClass="btn-lines dark light wow fadeInUp animated btn btn-default btn-green hvr-bounce-to-right" />
                    </div>
                </div>

            </div>           
                </section>

            </div>
        </div>
    </div>
</section><!--/#main-slider-->
        

<!--
==================================================
About Section Start
================================================== -->
<section id="about">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-6">
                <div class="block wow fadeInLeft" data-wow-delay=".3s" data-wow-duration="500ms">
                    <h2>
                    ABOUT US
                    </h2>
                    <p>
                      It is a website that enables you to search for flights that are available and available to you and compare prices for different airlines.
Just choose the date of departure and return and the number of passengers and search through the site.
                    </p>
                </div>
                
            </div>
            <div class="col-md-6 col-sm-6">
                <div class="block wow fadeInRight" data-wow-delay=".3s" data-wow-duration="500ms">
                    <img src="images/about/about.jpg" alt="">
                </div>
            </div>
        </div>
    </div>
</section> <!-- /#about -->



            <!--
            ==================================================
            Call To Action Section Start
            ================================================== -->
            <section id="call-to-action">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="block">
                                <h2 class="title wow fadeInDown" data-wow-delay=".3s" data-wow-duration="500ms">Do you have any questions?</h1>
                                <p class="wow fadeInDown" data-wow-delay=".5s" data-wow-duration="500ms">If you have a quistion, you can always contact us,<br>Checkout our contact information in 'contact us' page.</p>
                                <a href="Contact.aspx" class="btn btn-default btn-contact wow fadeInDown" data-wow-delay=".7s" data-wow-duration="500ms">Contact us</a>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </section>

</section>

</asp:Content>


