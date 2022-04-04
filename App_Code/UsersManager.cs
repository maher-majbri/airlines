using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for UsersManager
/// </summary>
public class UsersManager
{
	public UsersManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Insert(string name,string email, string password, string userstype)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Users(UserName,UserEmail,UserPassword, UserType) VALUES (@UserName,@UserEmail,@UserPassword,@UserType)");
        cmd.Parameters.AddWithValue("@UserName", name);
        cmd.Parameters.AddWithValue("@UserEmail", email);
        cmd.Parameters.AddWithValue("@UserPassword", password);
        cmd.Parameters.AddWithValue("@UserType", userstype);
    }


    public static void Update(string name,string email, string password, string usertype, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Users SET UserName=@UserName, UserEmail=@UserEmail,UserPassword=@UserPassword, UserType=@UserType WHERE UserID=@UserID");
        cmd.Parameters.AddWithValue("@UserName", name);
        cmd.Parameters.AddWithValue("@UserEmail", email);
        cmd.Parameters.AddWithValue("@UserPassword", password);
        cmd.Parameters.AddWithValue("@UserType", usertype);
        cmd.Parameters.AddWithValue("@UserID", id);
    }

    public static void Update(string name,string email, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Users SET UserName=@UserName, UserEmail=@UserEmail WHERE UserID=@UserID");
        cmd.Parameters.AddWithValue("@UserName", name);
        cmd.Parameters.AddWithValue("@UserEmail", email);
        cmd.Parameters.AddWithValue("@UserID", id);
    }

    public static void Update(string password, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Users SET UserPassword=@UserPassword WHERE UserID=@UserID");
        cmd.Parameters.AddWithValue("@UserPassword", password);
        cmd.Parameters.AddWithValue("@UserID", id);
    }

    public static void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("DELETE  FROM Users WHERE UserID=@UserID");
        cmd.Parameters.AddWithValue("@UserID", id);
        Database.ExecuteCommand(cmd);
    }

    public DataTable Select()
    {
        return Database.Execute("SELECT * FROM Users");
    }
  
    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID=@UserID");
        cmd.Parameters.AddWithValue("@UserID", id);
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

    public static DataRow CheckLogin(string email, string password)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserEmail=@UserEmail AND UserPassword=@UserPassword");
        cmd.Parameters.AddWithValue("@UserEmail", email);
        cmd.Parameters.AddWithValue("@UserPassword", password);
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