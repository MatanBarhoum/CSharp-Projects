using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BugTracker.Database
{
    public class NewReport
    {
        DBConnector connector = new DBConnector();

        public void InsertNewReport(SqlConnection sql, string title, string description, string author, string department, string status, string message)
        {
            //In charge of executing and inserting into the table all of the report data. gettings it data using parameters.
            connector.OpenDB(sql);
            var command = "INSERT INTO Tickets ([Title], [Description], [Author], [Department], [Status], [Message]) Values(@title, @description, @author, @department, @status, @message)";
            SqlCommand cmd = new SqlCommand(command, sql);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@department", department);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@message", message);
            cmd.ExecuteNonQuery();
            connector.CloseDB(sql);
        }
    }
}
