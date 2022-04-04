using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
        {
            lblMessage.Text = "Please enter email and password to login.";
        }
        DataRow dr = MemberManager.CheckLogin(txtEmail.Text, txtPassword.Text);
        if (dr == null)
        {
            lblMessage.Text = "Invalid login!";
        }
        else {
            lblMessage.Text = "";
            Session["MemberID"] = dr["MemberID"];
            Session["MemberDate"] = dr["MemberDate"];
            Session["MemberName"] = dr["MemberName"];
            Session["MemberEmail"] = dr["MemberEmail"];
            Session["MemberPassword"] = dr["MemberPassword"];
            Session["CityID"] = dr["CityID"];
            Response.Redirect("Default.aspx");
        }
    }
}