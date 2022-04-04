using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ScheduleManager
/// </summary>
public class ScheduleManager
{
	public ScheduleManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public static void Insert(int flight_id, DateTime departure, DateTime arrival, int seats)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Schedule(FlightID,Departure,Arrival,Seats) VALUES (@FlightID,@Departure,@Arrival,@Seats)");
        cmd.Parameters.AddWithValue("@FlightID", flight_id);
        cmd.Parameters.AddWithValue("@Departure", departure);
        cmd.Parameters.AddWithValue("@Arrival", arrival);
        cmd.Parameters.AddWithValue("@Seats", seats);
        Database.ExecuteCommand(cmd);
    }

    public static void Update(int flight_id, DateTime departure, DateTime arrival, int seats, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Schedule SET        FlightID=@FlightID,Departure=@Departure,Arrival=@Arrival,Seats=@Seats WHERE ScheduleID=@ScheduleID");
        cmd.Parameters.AddWithValue("@FlightID", flight_id);
        cmd.Parameters.AddWithValue("@Departure", departure);
        cmd.Parameters.AddWithValue("@Arrival", arrival);
        cmd.Parameters.AddWithValue("@Seats", seats);
        cmd.Parameters.AddWithValue("@ScheduleID", id);
        Database.ExecuteCommand(cmd);
    }

    public static void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("Delete FROM Schedule WHERE ScheduleID=@ScheduleID");
        cmd.Parameters.AddWithValue("@ScheduleID", id);
        Database.ExecuteCommand(cmd);
    }

    public static DataTable Select()
    {
        return Database.Execute("SELECT * FROM ScheduleView");
    }

    public static int GetCountByCompany(int company_id)
    {
        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM ScheduleView WHERE CompanyID=@CompanyID");
        cmd.Parameters.AddWithValue("@CompanyID", company_id);
        return Database.ExecuteScaler(cmd);
    }
    
    //call in 
    public static DataTable SelectByFlight(int flight_id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM ScheduleView WHERE FlightID=@FlightID");
        cmd.Parameters.AddWithValue("@FlightID", flight_id);
        return Database.Execute(cmd);
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE ScheduleID=@ScheduleID");
        cmd.Parameters.AddWithValue("@ScheduleID", id);

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