using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cdrDeparture_SelectionChanged(object sender, EventArgs e)
    {
        txtDateDeparture.Text = cdrDeparture.SelectedDate.ToShortDateString();
    }
    protected void cdrArrival_SelectionChanged(object sender, EventArgs e)
    {
        txtDateArrival.Text = cdrArrival.SelectedDate.ToShortDateString();
    }
}