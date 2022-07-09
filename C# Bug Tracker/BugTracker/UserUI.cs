using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BugTracker.Database;
using BugTracker.Handlers;
using System.Data.SqlClient;

namespace BugTracker
{
    public partial class UserUI : Form
    {
        public static int QueryID = 0;

        DBConnector connector = new DBConnector();
        public UserUI()
        {
            InitializeComponent();
        }
        private void btnNewReport_Click(object sender, EventArgs e)
        {
            StartNewReport();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartNewReport();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataBind();
        }
        private void btnShowTicket_Click(object sender, EventArgs e)
        {
            Thread details = new Thread(new ThreadStart(StartDetailsForm));
            details.Start();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome " + LoginForm.Username;
            DataBind();
            dataGridView1.Columns["Author"].Visible = false;
            dataGridView1.Columns["Department"].Visible = false;
            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Answer"].Visible = false;
        }

        public void LoadNewReport()
        {
            NewReport newReport = new NewReport();
            newReport.ShowDialog();
        }

        public void StartNewReport()
        {
            Thread startNewReport = new Thread(new ThreadStart(LoadNewReport));
            startNewReport.Start();
        }

        private void DataBind()
        {
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.OpenDB(con);
                SqlCommand cmd = new SqlCommand("select * from Tickets WHERE Author=@author", con);
                cmd.Parameters.AddWithValue("@author", LoginForm.Username);
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
                        dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                    }
                    else if (reader["status"].ToString() == "In Progress...")
                    {
                        dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Orange;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                    }
                    i++;
                }
                connector.CloseDB(con);
            }
        }

        private void StartDetailsForm()
        {
            var ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var Description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                connector.StartDetailForm(con, ID); // Calling the StartDetailForm function at DBQueryTicket.cs which run a query and set the properties of message and answer to their sql values.
            }
            TicketDetailsUI detailsForm = new TicketDetailsUI(ID, Title, Description, DBConnector.Message, DBConnector.Answer, 0);
            detailsForm.ShowDialog();
        }

        private void newReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewReport();
        }

        private void LoadQueryForm()
        {
            TicketsQuery queryForm = new TicketsQuery(LoginForm.Username);
            queryForm.ShowDialog();
        }
        private void myTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryID = 1;
            Thread queryform = new Thread(new ThreadStart(LoadQueryForm));
            queryform.Start();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread queryform = new Thread(new ThreadStart(StartDetailsForm));
            queryform.Start();
        }
    }
}
