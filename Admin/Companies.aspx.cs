using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Companies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (this.IsPostBack == false)
            {
                string x = Request.QueryString["id"];
                if (x != null)
                {
                    DataRow dr = CompaniesManager.Select(Convert.ToInt16(x));
                    if (dr != null)
                    {
                        txtID.Text = dr["CompanyID"].ToString();
                        txtName.Text = dr["CompanyName"].ToString();
                        txtEmail.Text = dr["CompanyEmail"].ToString();
                        txtPassword.Text = dr["CompanyPassword"].ToString();
                        SetEdit();
                    }
                }
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        CompaniesManager.Insert(txtName.Text,txtEmail.Text,txtPassword.Text);
        GridView1.DataBind();
        ClearForm();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        CompaniesManager.Update(txtName.Text, txtEmail.Text, txtPassword.Text, Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetNew();
        ClearForm();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        CompaniesManager.Delete(Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetNew();
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
    private void ClearForm()
    {
        txtName.Text = "";
        txtEmail.Text = "";
        txtPassword.Text = "";
        txtID.Text = "";
    }

 
    protected void btnNew_Click(object sender, EventArgs e)
    {
        ClearForm();
        SetNew();
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
        SetNew();
    }
}