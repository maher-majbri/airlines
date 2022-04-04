using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FlightsManager
/// </summary>
public class FlightsManager
{
	public FlightsManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Insert(string code,int company_id,int fromcityid,int tocityid, double price, string clas )
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Flights(FlightCode,CompanyID,FromCityID,ToCityID,FlightPrice,FlightClass) VALUES (@FlightCode,@CompanyID,@FromCityID,@ToCityID,@FlightPrice,@FlightClass)");
        cmd.Parameters.AddWithValue("@FlightCode", code);
        cmd.Parameters.AddWithValue("@CompanyID", company_id);
        cmd.Parameters.AddWithValue("@FromCityID", fromcityid);
        cmd.Parameters.AddWithValue("@ToCityID", tocityid);
        cmd.Parameters.AddWithValue("@FlightPrice", price);
        cmd.Parameters.AddWithValue("@FlightClass", clas);
        Database.ExecuteCommand(cmd);
    }

    public static void Update(string code, int company_id, int fromcityid, int tocityid, double price, string clas, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Flights SET FlightCode=@FlightCode,CompanyID=@CompanyID,FromCityID=@FromCityID,ToCityID=@ToCityID,FlightPrice=@FlightPrice,FlightClass=@FlightClass WHERE FlightID=@FlightID");
        cmd.Parameters.AddWithValue("@FlightCode", code);
        cmd.Parameters.AddWithValue("@CompanyID", company_id);
        cmd.Parameters.AddWithValue("@FromCityID", fromcityid);
        cmd.Parameters.AddWithValue("@ToCityID", tocityid);
        cmd.Parameters.AddWithValue("@FlightPrice", price);
        cmd.Parameters.AddWithValue("@FlightClass",clas);
        cmd.Parameters.AddWithValue("@FlightID", id);
        Database.ExecuteCommand(cmd);
    }

    public static void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("DELETE  FROM Flights WHERE FlightID=@FlightID");
        cmd.Parameters.AddWithValue("@FlightID", id);
        Database.ExecuteCommand(cmd);
    }

    public static DataTable Select()
    {
        return Database.Execute("SELECT * FROM FlightsView");
    }

    public static DataTable SelectByCompany(int company_id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM FlightsView WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", company_id);
        return Database.Execute(cmd);
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Flights WHERE FlightID=@FlightID");
        cmd.Parameters.AddWithValue("@FlightID", id);
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

    public static int GetCountByCompany(int company_id) {
        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Flights WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", company_id);
        return Database.ExecuteScaler(cmd);
    }

    public static bool IsUsed(int id)
    {
        //needs to be apdated to include other tables if needed
        SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE FlightID=@FlightID");
        cmd.Parameters.AddWithValue("@FlightID", id);
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
}

