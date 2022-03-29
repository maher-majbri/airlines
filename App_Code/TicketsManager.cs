using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for TicketsManager
/// </summary>
public class TicketsManager
{
    public TicketsManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public void Insert(string code , int reservation_id)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Tickets(TicketCode,ReservationID) VALUES (@TicketCode,@ReservationID)");
        cmd.Parameters.AddWithValue("@TicketCode", code);
        cmd.Parameters.AddWithValue("@ReservationID", reservation_id);
        Database.ExecuteCommand(cmd);
    }

    public void Update(string code, int reservation_id, int id)
    {
        SqlCommand cmd = new SqlCommand("UPDATE Tickets SET TicketCode=@TicketCode,ReservationID=@ReservationID WHERE TicketID=@TicketID");
        cmd.Parameters.AddWithValue("@TicketCode", code);
        cmd.Parameters.AddWithValue("@ReservationID", reservation_id);
        cmd.Parameters.AddWithValue("@TicketID", id);
        Database.ExecuteCommand(cmd);
    }

    public void Delete(string code, int reservation_id, int id)
    {
        SqlCommand cmd = new SqlCommand("DELETE FROM Tickets WHERE TicketID=@TicketID");
        cmd.Parameters.AddWithValue("@TicketID", id);
        Database.ExecuteCommand(cmd);
    }

    public DataTable Select()
    {
        return Database.Execute("SELECT * FROM TicketsView");
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE TicketID=@TicketID");
        cmd.Parameters.AddWithValue("@TicketID", id);
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