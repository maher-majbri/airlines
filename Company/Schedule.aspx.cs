using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // we must take company id from session
        //FlightsManager.Insert(txtCode.Text, 1, Convert.ToInt16(ddlFrom.SelectedValue), Convert.ToInt16(ddlTo.SelectedValue), Convert.ToDouble(txtPrice.Text), Convert.ToString(ddlClass.SelectedItem));
        grdSchedule.DataBind();
        ClearForm();
    }

    private void ClearForm()
    {
         //  txtPrice.Text = "";
     
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
}