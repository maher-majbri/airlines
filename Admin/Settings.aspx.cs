using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Settings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            DataRow dr = UsersManager.Select(Convert.ToInt16(Session["UserID"]));
            if (dr != null)
            {
                txtName.Text = dr["UserName"].ToString();
                txtEmail.Text = dr["UserEmail"].ToString();
            }

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (txtName.Text == "")
        {
            lblMessage1.Text = "Please enter your name";
            return;
        }
        if (txtEmail.Text == "")
        {
            lblMessage1.Text = "Please enter your email";
            return;
        }
        UsersManager.Update(txtName.Text, txtEmail.Text, Convert.ToInt16(Session["UserID"]));
        lblMessage1.Text = "Your Profile Updated Successfully!";
    }

    protected void btnUpdatePassword_Click(object sender, EventArgs e)
    {
        if (txtOldPassword.Text != Session["UserPassword"].ToString())
        {
            lblMessage2.Text = "Old password is not correct";
            return;
        }
        if (txtNewPassword.Text == "")
        {
            lblMessage2.Text = "Please enter new password";
            return;
        }
        if (txtConfirmPassword.Text != txtNewPassword.Text)
        {
            lblMessage2.Text = "Password confirmation doesn't match";
            return;
        }
        UsersManager.Update(txtNewPassword.Text, Convert.ToInt16(Session["UserID"]));
        lblMessage2.Text = "Password Updated Successfully!";
    }

}