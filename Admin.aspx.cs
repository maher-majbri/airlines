using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataRow dr = UsersManager.CheckLogin(txtEmail.Text, txtPassword.Text);
        if (dr == null)
        {
            lblMessage.Text = "Login Fail";
        }
        else
        {
            Session["UserID"] = dr["UserID"];
            Session["UserName"] = dr["UserName"];
            Session["UserEmail"] = dr["UserEmail"];
            Session["UserPassword"] = dr["UserPassword"];
            Session["UserType"] = dr["UserType"];
            Response.Redirect("Admin");
        }
    }
}