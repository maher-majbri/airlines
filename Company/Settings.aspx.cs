using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_Settings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            DataRow dr = CompaniesManager.Select(Convert.ToInt16(Session["CompanyID"]));
            if (dr != null)
            {
                txtName.Text = dr["CompanyName"].ToString();
                txtEmail.Text = dr["CompanyEmail"].ToString();
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
        CompaniesManager.Update(txtName.Text, txtEmail.Text, Convert.ToInt16(Session["CompanyID"]));
        lblMessage1.Text = "Your Profile Updated Successfully!";
    }

    protected void btnUpdatePassword_Click(object sender, EventArgs e)
    {
        if (txtOldPassword.Text != Session["CompanyPassword"].ToString())
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
        CompaniesManager.Update(txtNewPassword.Text, Convert.ToInt16(Session["CompanyID"]));
        lblMessage2.Text = "Password Updated Successfully!";
    }

}