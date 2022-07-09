using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BugTracker.Database;
using System.Data.SqlClient;
using System.Threading;

namespace BugTracker
{
    public partial class TicketsQuery : Form
    {
        DBQueryTickets Query = new DBQueryTickets();
        DBConnector connector = new DBConnector();
        private string Username { get; set; }
        public static string Message { get; set; }
        public static string answer { get; set; }
        public TicketsQuery()
        {
            InitializeComponent();
        }

        public TicketsQuery(string username)
        {
            InitializeComponent();
            this.Username = username;    // Constructor get information and then set the passed variable to a private variable within the class.

        }

        private void TicketsQuery_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connector.dbcon))
                {
                    if (AdminUI.QueryID == 0)
                    {
                        // Open Tickets
                        Query.OpenQuery(con); // Pass information + Call to DBQueryTickets OpenQuery() function.
                    }
                    else if (AdminUI.QueryID == 1)
                    {
                        // In Progress Tickets
                        Query.InProgressQuery(con); // Pass information + Call to DBQueryTickets InProgressQuery() function.
                    }
                    else if (UserUI.QueryID == 1)
                    {
                        Query.MyTicketsQuery(con, Username); // Pass information + Call to DBQueryTickets MyTicketsQuery() function.
                    }
                    else
                    {
                        // Closed Tickets
                        Query.ClosedQuery(con); // Pass information + Call to DBQueryTickets ClosedQuery() function.
                    }
                }
                QueryDataGridView.Columns["ID"].Visible = false;
                QueryDataGridView.Columns["Author"].Visible = false;
                QueryDataGridView.Columns["Department"].Visible = false;
                QueryDataGridView.Columns["Message"].Visible = false;
                QueryDataGridView.Columns["Answer"].Width = 250;
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void StartDetailsForm()
        {
            var ID = Convert.ToInt32(QueryDataGridView.CurrentRow.Cells[0].Value.ToString());
            var Title = QueryDataGridView.CurrentRow.Cells[1].Value.ToString();
            var Description = QueryDataGridView.CurrentRow.Cells[2].Value.ToString();
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.StartDetailForm(con, ID); // Calling the StartDetailForm function at DBQueryTicket.cs which run a query and set the properties of message and answer to their sql values.
            }
            var UserOrAdmin = 2;
            if (UserUI.QueryID == 1)
            {
                UserOrAdmin = 0; //User
            } else
            {
                UserOrAdmin = 1; //Admin
            }
            TicketDetailsUI detailsForm = new TicketDetailsUI(ID, Title, Description, DBConnector.Message, DBConnector.Answer, UserOrAdmin);
            detailsForm.ShowDialog();
        }
        private void QueryDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread details = new Thread(new ThreadStart(StartDetailsForm));
            details.Start();
        }
    }
}
