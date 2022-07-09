using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BugTracker.Database;
using BugTracker.Handlers;
using System.Threading;
using System.Runtime.InteropServices;

namespace BugTracker
{
    public partial class AdminUI : Form
    {
        /* Round Corners for button and etc */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        DBConnector connector = new DBConnector();
        public static int OpenTickets { get; set; }
        public static int InProgressTickets { get; set; }
        public static int ClosedTickets { get; set; }
        public static int QueryID = 3;
         public AdminUI()
        {
            InitializeComponent();
            /* Making the borders of object cornered. */
            this.btnDetails.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.btnDetails.Width, this.btnDetails.Height, 20, 20));
            this.btnRefresh.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.btnRefresh.Width, this.btnRefresh.Height, 20, 20));
            this.txtSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.txtSearch.Width, this.txtSearch.Height, 20, 20));
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugTrackerDataSet2.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter2.Fill(this.bugTrackerDataSet2.Tickets);
            DataBind(); /* Fill the datagridview with data. calling a function on this class. */
            TicketsCounter(); /* function in charge for counting the tickets state and increment the numbers of each. then it shows in the status bar. */
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockTextBox.Text = DateTime.Now.ToString(); // set the running live clock at the top of the menu strip.
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            /* When clicking of details button, it's open the TicketDetailsUI using Thread. */
            Thread details = new Thread(new ThreadStart(StartDetailsForm));
            details.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search Function TBD
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresher(); // Refresh the DataGridView
            TicketsCounter(); // Count the Tickets once again the check for update numbers.
        }

        /* Function Section */
        private void DataBind()
        {
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.OpenDB(con);
                SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Status='Open' or Status='In Progress...'", con); // Set the command to string and connection, if ticket is closed, it won't show in the main datagridview.
                SqlDataAdapter sd = new SqlDataAdapter(cmd); // Get the data from the command
                DataTable table = new DataTable(); // set a new datatable object
                sd.Fill(table); // set the data to that table
                dataGridView1.DataSource = table; // fills the datagridview with the table.
                var reader = cmd.ExecuteReader(); // execute reader that reading all the content and then checking for specific details.
                var i = 0; // for each object that the reader read, this will be increment by one, similar to for loop.
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "Open") // if the ticket is open
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Green; // set to green
                    }
                    else if (reader["status"].ToString() == "In Progress...") // if in progress
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Orange; // set to orange
                    }
                    else // if closed
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Red; //set to red
                    }
                    i++;
                }
                reader.Close();
                connector.CloseDB(con);
            }
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 120;
        }

        private void Refresher() // Refresh the datagridview, the only difference is the width sets.
        {
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.OpenDB(con);
                SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Status='Open' or Status='In Progress...'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sd.Fill(table);
                dataGridView1.DataSource = table;
                var reader = cmd.ExecuteReader();
                var i = 0;
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "Open")
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                    }
                    else if (reader["status"].ToString() == "In Progress...")
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Orange;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                    }
                    i++;
                }
                reader.Close();
                connector.CloseDB(con);
            }
        }
        private void StartDetailsForm() // passing the details from the datagridview to variables and then into the TicketDetailsUI constructor. Then, It showing the specific informatino of the required ticket in the new form.
        {
            var ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var Description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.StartDetailForm(con, ID); // Calling the StartDetailForm function at DBQueryTicket.cs which run a query and set the properties of message and answer to their sql values.
            }
            TicketDetailsUI detailsForm = new TicketDetailsUI(ID, Title, Description, DBConnector.Message, DBConnector.Answer, 1);
            detailsForm.ShowDialog();
        }

        private void TicketsCounter() // Counts the tickets and then increment each variable according to their value.
        {
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.OpenDB(con);
                SqlCommand cmd = new SqlCommand("select * from Tickets", con);
                var reader = cmd.ExecuteReader();
                OpenTickets = 0;
                InProgressTickets = 0;
                ClosedTickets = 0;
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "Open")
                    {
                        OpenTickets += 1;
                    }
                    else if (reader["status"].ToString() == "In Progress...")
                    {
                        InProgressTickets += 1;
                    }
                    else
                    {
                        ClosedTickets += 1;
                    }
                }
                reader.Close();
                connector.CloseDB(con);
                OpenStatus.ForeColor = Color.Green;
                OpenStatus.Text = "Open Tickets: " + OpenTickets.ToString() + "   "; 

                InProgressStatus.ForeColor = Color.Orange;
                InProgressStatus.Text = "In Progress Tickets: " + InProgressTickets.ToString() + "   ";

                ClosedStatus.ForeColor = Color.Red;
                ClosedStatus.Text = "Closed Tickets: " + ClosedTickets.ToString() + "   ";
            }
        }

        private void ticketDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread details = new Thread(new ThreadStart(StartDetailsForm)); // Starting thread to open the DetailsformUI when clicked from the stripMenu.
            details.Start();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Same as refresh button, from the stripmenu.
            Refresher(); 
            TicketsCounter();
        }

        private void LoadQueryForm()
        {
            // Loading the form and then show the dialog, this function is passed to thread.
            TicketsQuery queryForm = new TicketsQuery();
            queryForm.ShowDialog();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryID = 0; // Settings QueryID and then when the QueryForm runs it's determine if this is an admin or user, then accordingly sets the button, labels and what they see in that form.
            Thread queryform = new Thread(new ThreadStart(LoadQueryForm));
            queryform.Start();
        }

        private void inProgresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryID = 1; // Settings QueryID and then when the QueryForm runs it's determine if this is an admin or user, then accordingly sets the button, labels and what they see in that form.
            Thread queryform = new Thread(new ThreadStart(LoadQueryForm));
            queryform.Start();
        }

        private void closedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryID = 2; // Settings QueryID and then when the QueryForm runs it's determine if this is an admin or user, then accordingly sets the button, labels and what they see in that form.
            Thread queryform = new Thread(new ThreadStart(LoadQueryForm));
            queryform.Start();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread details = new Thread(new ThreadStart(StartDetailsForm));
            details.Start();
        }
    }
}
