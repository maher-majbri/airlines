using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Members : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (this.IsPostBack == false)
            {
                string x = Request.QueryString["id"];
                if (x != null)
                {
                    DataRow dr = MemberManager.Select(Convert.ToInt16(x));
                    if (dr != null)
                    {
                        txtID.Text = dr["MemberID"].ToString();
                        txtName.Text = dr["MemberName"].ToString();
                        txtEmail.Text = dr["MemberEmail"].ToString();
                        txtPhone.Text = dr["MemberPhone"].ToString();
                        txtPassword.Text = dr["MemberPassword"].ToString();
                        ddlCity.SelectedValue = dr["CityID"].ToString();
                        SetEdit();
                    }
                }
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        MemberManager.Insert(txtName.Text,txtEmail.Text,txtPhone.Text,txtPassword.Text,Convert.ToInt16 (ddlCity.SelectedValue));
        ddlCity.DataBind();
        GridView1.DataBind();
        ClearForm();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        MemberManager.Update(txtName.Text,txtEmail.Text,txtPhone.Text,txtPassword.Text,Convert.ToInt16(ddlCity.SelectedValue), Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
        ClearForm();
        GridView1.DataBind();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {

        MemberManager.Delete(Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
        ClearForm();
        GridView1.DataBind();

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
        txtEmail.Text ="";
        txtPhone.Text="";
        txtPassword.Text = "";
        ddlCity.SelectedIndex = 0;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
        SetNew();
    }
}