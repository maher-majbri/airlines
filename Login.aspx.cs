﻿using System;
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
        DataRow dr = MemberManager.CheckLogin(txtEmail.Text, txtPassword.Text);
        if (dr == null)
        {
            lblMessage.Text = "Login Fail";
        }
        else {
            lblMessage.Text = "Hello " + dr["MemberName"].ToString();
        }
    }
}