using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            string x = Request.QueryString["id"];
            if (x != null)
            {
                DataRow dr = ScheduleManager.Select(Convert.ToInt16(x));
                if (dr != null)
                {
                    txtID.Text = dr["ScheduleID"].ToString();
                    cdrDeparture.SelectedDate = Convert.ToDateTime(dr["Departure"]);
                    cdrArrival.SelectedDate = Convert.ToDateTime(dr["Arrival"]);
                    ddlFlight.SelectedValue =  dr["FlightID"].ToString();
                    txtSeats.Text = dr["Seats"].ToString();
                    SetEdit();
                }
            }
        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
      //   we must take company id from session
        ScheduleManager.Insert(Convert.ToInt16(ddlFlight.SelectedValue), Convert.ToDateTime(cdrDeparture.SelectedDate), Convert.ToDateTime(cdrArrival.SelectedDate), Convert.ToInt16(txtSeats.Text));
        grdSchedule.DataBind();
        ClearForm();
    }

    private void ClearForm()
    {
       txtSeats.Text= "";
       cdrDeparture.SelectedDate = DateTime.Now.Date;
       cdrArrival.SelectedDate = DateTime.Now.Date;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
    protected void cdrDeparture_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void cdrArrival_SelectionChanged(object sender, EventArgs e)
    {

    }

    public void SetEdit()
    {
        btnAdd.Enabled = false;
        btnSave.Enabled = true;
        btnDelete.Enabled = true;
    }

    public void SetNew()
    {
        btnAdd.Enabled = true;
        btnDelete.Enabled = false;
        btnSave.Enabled = false;
    }

}