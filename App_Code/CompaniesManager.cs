using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CompanyManager
/// </summary>
public class CompaniesManager
{
    public CompaniesManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void Insert(string name,string email, string password)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Companies(CompanyName,CompanyEmail,CompanyPassword) VALUES (@CompanyName,@CompanyEmail,@CompanyPassword)");
        cmd.Parameters.AddWithValue("@CompanyName", name);
        cmd.Parameters.AddWithValue("@CompanyEmail", email);
        cmd.Parameters.AddWithValue("@CompanyPassword", password);
        Database.ExecuteCommand(cmd);
    }


    public static void Update(string name, string email, string password, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Companies SET CompanyName=@CompanyName,CompanyEmail=@CompanyEmail,CompanyPassword=@CompanyPassword WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyName", name);
        cmd.Parameters.AddWithValue("@CompanyEmail", email);
        cmd.Parameters.AddWithValue("@CompanyPassword", password);
        cmd.Parameters.AddWithValue("@CompanyID", id);
        Database.ExecuteCommand(cmd);
    }

    public static void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("DELETE  FROM  Companies WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", id);
        Database.ExecuteCommand(cmd);
    }

    public static DataTable Select()
    {
        return Database.Execute("SELECT * FROM Companies");
    }


    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Companies WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", id);
        DataTable dt = Database.Execute(cmd);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0];
        }
        else
        {
            return null;
        }
    }

    public static bool IsUsed(int id)
    {
        //needs to be apdated to include other tables if needed
        SqlCommand cmd = new SqlCommand("SELECT * FROM Flights WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", id);
        DataTable dt = Database.Execute(cmd);
        if (dt.Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static DataRow CheckLogin(string email, string password)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Company WHERE CompanyEmail=@CompanyEmail AND CompanyPassword=@CompanyPassword");
        cmd.Parameters.AddWithValue("@CompanyEmail", email);
        cmd.Parameters.AddWithValue("@CompanyPassword", password);
        DataTable dt = Database.Execute(cmd);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0];
        }
        else
        {
            return null;
        }
    }

}