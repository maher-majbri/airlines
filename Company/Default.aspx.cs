using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblNumberOfReservations.Text =   ReservationsManager.GetCountByCompany(Convert.ToInt16(Session["CompanyID"])).ToString();
        lblNumberOfFlights.Text = FlightsManager.GetCountByCompany(Convert.ToInt16(Session["CompanyID"])).ToString();
        lblNumberOfScheduleSetup.Text = ScheduleManager.GetCountByCompany(Convert.ToInt16(Session["CompanyID"])).ToString();
    }
}