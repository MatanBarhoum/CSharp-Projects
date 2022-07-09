using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BugTracker.Database;

namespace BugTracker
{
    public partial class NewReport : Form
    {
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string department { get; set; }  
        public string status { get; set; }
        public string message { get; set; }

        DBConnector connector = new DBConnector();

        public NewReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connector.dbcon))
            {
                //New report form, taking all the details from the field and pass them to the InsertNewReport function from DataBase.NewReport.cs
                title = txtTitle.Text;
                description = txtDescription.Text;
                author = LoginForm.Username;
                department = txtDepartment.Text;
                status = "Open";
                message =   msgTextBox.Text;
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(department) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("One or more field is missing.", "Error");
                }
                else
                {
                    Database.NewReport newReport = new Database.NewReport();
                    newReport.InsertNewReport(con, title, description, author, department, status, message);
                    MessageBox.Show("Your Report has been sent.");
                    this.Close();
                }
            }
        }

        private void NewReport_Load(object sender, EventArgs e)
        {

        }
    }
}
