using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Flights : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            string x = Request.QueryString["id"];
            if (x != null)
            {
                DataRow dr = FlightsManager.Select(Convert.ToInt16(x));
                if (dr != null)
                {
                    txtID.Text = dr["FlightID"].ToString();
                    txtCode.Text = dr["FlightCode"].ToString();
                    ddlFrom.Text = dr["FromCityID"].ToString();
                    ddlTo.Text = dr["ToCityID"].ToString();
                    txtPrice.Text = dr["FlightPrice"].ToString();
                    ddlClass.Text = dr["FlightClass"].ToString();
                    SetEdit();
                }
            }
        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // we must take company id from session
        FlightsManager.Insert(txtCode.Text, Convert.ToInt16(Session["CompanyID"]), Convert.ToInt16(ddlFrom.SelectedValue), Convert.ToInt16(ddlTo.SelectedValue), Convert.ToDouble(txtPrice.Text), Convert.ToString(ddlClass.SelectedItem));
        GridView1.DataBind();
        ClearForm();
    }

    private void ClearForm()
    {
        txtPrice.Text = "";
        //
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        FlightsManager.Update(txtCode.Text, Convert.ToInt16(Session["CompanyID"]), Convert.ToInt16(ddlFrom.SelectedValue), Convert.ToInt16(ddlTo.SelectedValue), Convert.ToDouble(txtPrice.Text), Convert.ToString(ddlClass.SelectedItem), Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
        ClearForm();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        FlightsManager.Delete(Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
        ClearForm();
    }

    protected void btnClear_Click(object sender, EventArgs e)
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