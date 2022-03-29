using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Admin_Users : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            string x = Request.QueryString["id"];
            if (x != null)
            {
                DataRow dr = UsersManager.Select(Convert.ToInt16(x));
                if (dr != null)
                {
                    txtID.Text = dr["UserID"].ToString();
                    txtName.Text = dr["UserName"].ToString();
                    txtEmail.Text = dr["UserEmail"].ToString();
                    txtPassword.Text = dr["UserPassword"].ToString();
                    SetEdit();
                }
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        UsersManager.Insert(txtName.Text,txtEmail.Text,txtPassword.Text ,ddlType.Text );
        GridView1.DataBind();
        ClearForm();  
        lblMessage.Text = "Added!";
    }
   
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        UsersManager.Update(txtName.Text, txtEmail.Text, txtPassword.Text, ddlType.Text, Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        ClearForm();
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        UsersManager.Delete(Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        ClearForm();
    }

    public void SetEdit()
    {
        btnAdd.Enabled = false;
        btnSave.Enabled = true;
        btnDelete.Enabled = true;
    }

    public void SetNew()
    {
        btnAdd.Enabled = true;
        btnDelete.Enabled = false;
        btnSave.Enabled = false;
    }
   
    public void ClearForm() {
        txtID.Text = "";
        txtName.Text = "";
        txtEmail.Text = "";
        txtPassword.Text = "";
        ddlType.SelectedIndex = 0;
        SetNew();
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
        SetEdit();
    }
}
