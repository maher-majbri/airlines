using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MemberManager
{
	public MemberManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Insert(string name, string email,string phone, string password, int city)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Members(MemberName,MemberEmail,MemberPhone,MemberPassword,CityID) VALUES (@MemberName,@MemberEmail,@MemberPhone,@MemberPassword,@CityID)");
        cmd.Parameters.AddWithValue("@MemberName", name);
        cmd.Parameters.AddWithValue("@MemberEmail", email);
        cmd.Parameters.AddWithValue("@MemberPhone", phone);
        cmd.Parameters.AddWithValue("@MemberPassword", password );
        cmd.Parameters.AddWithValue("@CityID", city );

        
        Database.ExecuteCommand(cmd);
    }


    public static void Update(string name, string email, string phone, string password, int city, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Members SET MemberName=@MemberName,MemberEmail=@MemberEmail,MemberPhone=@MemberPhone,MemeberPassword=@MemeberPassword,CityID=@CityID WHERE MemberID=@MemberID");
        cmd.Parameters.AddWithValue("@MemberName", name);
        cmd.Parameters.AddWithValue("@MemberEmail", email );
        cmd.Parameters.AddWithValue("@MemberPhone", phone);
        cmd.Parameters.AddWithValue("@MemeberPassword", password);
        cmd.Parameters.AddWithValue("@CityID", city);
        cmd.Parameters.AddWithValue("@MemberID", id);
        Database.ExecuteCommand(cmd);
    }

    public static  void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("DELETE  FROM Members WHERE MemberID=@MemberID");
        cmd.Parameters.AddWithValue("@MemberID", id);
        Database.ExecuteCommand(cmd);
    }

    public DataTable Select()
    {
        return Database.Execute("SELECT * FROM MembersView");
    }

    public DataTable SelectByCity(int city_id)
    {
          SqlCommand cmd = new SqlCommand  ("SELECT * FROM MembersView WHERE CityID=@CityID");
          cmd.Parameters.AddWithValue("@CityID", city_id);
          return Database.Execute(cmd);
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE MemberID=@MemberID");
        cmd.Parameters.AddWithValue("@MemberID", id);

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
        SqlCommand cmd = new SqlCommand("SELECT * FROM Reservations WHERE MemberID=@MemberID");
        cmd.Parameters.AddWithValue("@MemberID", id);
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

    public static DataRow CheckLogin(string email , string password)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE MemberEmail=@MemberEmail AND MemberPassword=@MemberPassword");
        cmd.Parameters.AddWithValue("@MemberEmail", email);
        cmd.Parameters.AddWithValue("@MemberPassword", password);
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