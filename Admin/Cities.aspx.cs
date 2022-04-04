using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Cities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (this.IsPostBack == false)
            {
                string x = Request.QueryString["id"];
                if (x != null)
                {
                    DataRow dr = CityManager.Select(Convert.ToInt16(x));
                    if (dr != null)
                    {
                        txtID.Text = dr["CityID"].ToString();
                        txtName.Text = dr["CityName"].ToString();
                        SetEdit();
                    }
                }
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        CityManager.Insert(txtName.Text);
        GridView1.DataBind();
        ClearForm();

       
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        CityManager.Update(txtName.Text, Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
        ClearForm();
        GridView1.DataBind();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        CityManager.Delete(Convert.ToInt16(txtID.Text));
        GridView1.DataBind();
        SetEdit();
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
        txtID.Text = "";
        txtName.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
        SetNew();
    }
}
