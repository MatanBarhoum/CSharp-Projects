using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BugTracker.Database
{
    public class DBConnector
    {
        public static string Message { get; set; } // Property of message, get it from the reader when called and then set it and show in the form. static for calling all around the classes.
        public static string Answer { get; set; } // Propery of answer, get it from the reader when called and then set it and show in the form. static for calling all around the classes.
        public string dbcon = "Data Source=MATAN-235;Initial Catalog=BugTracker;Integrated Security=True;MultipleActiveResultSets=True";

        public void OpenDB(SqlConnection sql) // Opening the SQL connection using a composition call.
        {
            sql.Open();
        }
        public void CloseDB(SqlConnection sql) // Closing the SQL connection using a composition call.
        {
            sql.Close();
        }

        public void StartDetailForm(SqlConnection sql, int ID) 
        {
            // The details form that is been called from several classes. get the SQL connection and ID of the ticket, then using query to get a specific records. then settings the Message and Answer props to be showed in the TicketDetailsUI.cs Form.
            OpenDB(sql);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE ID=@id", sql);
            cmd.Parameters.AddWithValue("@id", ID);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Message = reader["Message"].ToString();
                Answer = reader["Answer"].ToString();
            }
            reader.Close();
            CloseDB(sql);
        }
    }
}
