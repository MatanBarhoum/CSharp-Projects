using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace BugTracker.Database
{
    public class DBQueryTickets
    {
        DBConnector connector = new DBConnector();
        public void OpenQuery(SqlConnection sql)
        {
            // In charge of executing the specific Query where status is open (ticket is in open status) and then coloring it accordingly.
            connector.OpenDB(sql);
            SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Status='Open'", sql);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            TicketsQuery.QueryDataGridView.DataSource = table;
            var reader = cmd.ExecuteReader();
            var i = 0;
            while (reader.Read())
            {
                if (reader["Status"].ToString() == "Open")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                else if (reader["status"].ToString() == "In Progress...")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Orange;
                }
                else
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                i++;
            }
                
                connector.CloseDB(sql);
        }

        public void InProgressQuery(SqlConnection sql)
        {
            // In charge of executing the specific Query where status is open (ticket is in open status) and then coloring it accordingly.
            connector.OpenDB(sql);
            SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Status='In Progress...'", sql);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            TicketsQuery.QueryDataGridView.DataSource = table;
            var reader = cmd.ExecuteReader();
            var i = 0;
            while (reader.Read())
            {
                if (reader["Status"].ToString() == "Open")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                else if (reader["status"].ToString() == "In Progress...")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Orange;
                }
                else
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                i++;
            }
            
            connector.CloseDB(sql);
        }

        public void ClosedQuery(SqlConnection sql)
        {
            // In charge of executing the specific Query where status is open (ticket is in open status) and then coloring it accordingly.
            connector.OpenDB(sql);
            SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Status='Closed'", sql);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            TicketsQuery.QueryDataGridView.DataSource = table;
            var reader = cmd.ExecuteReader();
            var i = 0;
            while (reader.Read())
            {
                if (reader["Status"].ToString() == "Open")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                else if (reader["status"].ToString() == "In Progress...")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Orange;
                }
                else
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                i++;
            }

            connector.CloseDB(sql);
        }

        public void MyTicketsQuery(SqlConnection sql, string username)
        {
            // In charge of executing the specific Query where author is the username (so it'll show only the user tickets) and then coloring the status accordingly.
            connector.OpenDB(sql);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE Author=@author", sql);
            cmd.Parameters.AddWithValue("@author", username);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            TicketsQuery.QueryDataGridView.DataSource = dataTable;
            var reader = cmd.ExecuteReader();
            var i = 0;
            while (reader.Read())
            {
                if (reader["Status"].ToString() == "Open")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                else if (reader["status"].ToString() == "In Progress...")
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Orange;
                }
                else
                {
                    TicketsQuery.QueryDataGridView.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                i++;
            }
            connector.CloseDB(sql);
        }

        public void TicketAnswer(SqlConnection sql, string answer, string status, int id)
        {
            // When an admin is updating a ticket, it sets the answer and status of the tickets to a specific ticket id.
            connector.OpenDB(sql);
            SqlCommand cmd = new SqlCommand("UPDATE Tickets SET Answer=@answer, Status=@status WHERE id=@id", sql);
            cmd.Parameters.AddWithValue("@answer", answer);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connector.CloseDB(sql);
        }
    }
}
