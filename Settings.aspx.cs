using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Settings : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MemberID"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!this.IsPostBack) { 
            DataRow dr = MemberManager.Select(Convert.ToInt16(Session["MemberID"]));
            if (dr != null)
            {
                txtName.Text = dr["MemberName"].ToString();
                txtEmail.Text = dr["MemberEmail"].ToString();
                txtPhone.Text = dr["MemberPhone"].ToString();
                ddlCity.SelectedValue = dr["CityID"].ToString();
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
        if (txtPhone.Text == "")
        {
            lblMessage1.Text = "Please enter your phone";
            return;
        }
        MemberManager.Update(txtName.Text, txtEmail.Text, txtPhone.Text, Convert.ToInt16(ddlCity.SelectedValue), Convert.ToInt16(Session["MemberID"]));
        lblMessage1.Text = "Your Profile Updated Successfully!";
    }

    protected void btnUpdatePassword_Click(object sender, EventArgs e)
    {
        if (txtOldPassword.Text != Session["MemberPassword"].ToString())
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
        MemberManager.Update(txtNewPassword.Text ,Convert.ToInt16( Session["MemberID"]));
        lblMessage2.Text = "Password Updated Successfully!";
    }


}