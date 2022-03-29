using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ReservationsManager
/// </summary>
public class ReservationsManager
{
	public ReservationsManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Insert(int member_id, int schedule_id, int adults,int children)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Reservations(MemberID,ScheduleID,Adults,Children) VALUES (@MemberID,@ScheduleID,,@Adults,@Children)");
        cmd.Parameters.AddWithValue("@MemberID", member_id);
        cmd.Parameters.AddWithValue("@ScheduleID", schedule_id);
        cmd.Parameters.AddWithValue("@Adults", adults);
        cmd.Parameters.AddWithValue("@Children", children);
        Database.ExecuteCommand(cmd);
    }

    public static void Update(int member_id, int schedule_id, int adults,int children,int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Reservations SET MemberID=@MemberID,ScheduleID=@ScheduleID,Adults=@Adults,Children=@Children WHERE ReservationsID=@ReservationsID");
        cmd.Parameters.AddWithValue("@MemberID", member_id);
        cmd.Parameters.AddWithValue("@ScheduleID", schedule_id);
        cmd.Parameters.AddWithValue("@Adults", adults);
        cmd.Parameters.AddWithValue("@Children", children);
        cmd.Parameters.AddWithValue("@ReservationsID", id);
        Database.ExecuteCommand(cmd);
    }

    public static void Delete(int id)
    {
        SqlCommand cmd = new SqlCommand("Delete FROM Reservations WHERE ReservationsID=@ReservationsID");
        cmd.Parameters.AddWithValue("@ReservationsID", id);
        Database.ExecuteCommand(cmd);
    }

    public static DataTable Select()
    {
        return Database.Execute("SELECT * FROM Reservations");
    }

    //call in member dashboard
    public static DataTable SelectByMember(int member_id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM ReservationsView WHERE MemberID=@MemberID");
        cmd.Parameters.AddWithValue("@MemberID", member_id);
        return Database.Execute(cmd);
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM ReservationsView WHERE ReservationsID=@ReservationsID");
        cmd.Parameters.AddWithValue("@ReservationsID", id);

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