using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Company : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataRow dr = CompaniesManager.CheckLogin(txtEmail.Text, txtPassword.Text);
        if (dr == null)
        {
            lblMessage.Text = "Login Fail";
        }
        else
        {
            Session["CompanyID"] = dr["CompanyID"];
            Session["CompanyDate"] = dr["CompanyDate"];
            Session["CompanyName"] = dr["CompanyName"];
            Session["CompanyEmail"] = dr["CompanyEmail"];
            Session["CompanyPassword"] = dr["CompanyPassword"];
            Response.Redirect("Company");
        }
    }
}