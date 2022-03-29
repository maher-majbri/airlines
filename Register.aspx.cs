using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //call method to add member to database
        MemberManager.Insert(txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text, Convert.ToInt16( ddlCity.SelectedValue));
        lblMessage.Text = "Thank you!";
    }
}