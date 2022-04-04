using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("../");
        }

    }
    protected void lbtn_Click(object sender, EventArgs e)
    {
        Session["UserID"] = null;
        Session["UserName"] = null;
        Session["UserEmail"] = null;
        Session["UserPassword"] = null;
        Session["UserType"] = null;
        Response.Redirect("../");
    }
}
