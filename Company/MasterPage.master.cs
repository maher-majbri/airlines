using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CompanyID"] == null) {
            Response.Redirect("../");
        }
    }
    protected void lbtn_Click(object sender, EventArgs e)
    {
        Session["CompanyID"] = null;
        Session["CompanyDate"] = null;
        Session["CompanyName"] = null;
        Session["CompanyEmail"] = null;
        Session["CompanyPassword"] = null;
        Response.Redirect("../");
    }
}
