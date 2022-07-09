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

namespace BugTracker
{
    public partial class TicketDetailsUI : Form
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public int FormID { get; set; } 

        DBQueryTickets queryTickets = new DBQueryTickets();
        DBConnector connector = new DBConnector();

        public TicketDetailsUI(int ID, string Title, string Description, string Message, string answer)
        {
            InitializeComponent();
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Message = Message;
            this.Answer = answer;
        }

        public TicketDetailsUI(int ID, string Title, string Description, string Message, string answer, int formID) //Overloading constructor that is used by UserUI.cs form to pass formID to determine if from adminUI or not.
        {
            InitializeComponent();
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Message = Message;
            this.Answer = answer;
            this.FormID = formID; // this will be used to determine wheter it is user who calling the form or admin and then execute the form accordingly.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicketDetailsUI_Load(object sender, EventArgs e)
        {
            if (FormID != 1) //Hides some function from users so they can't perform actions, only view. Better than create another form ... :)
            {
                label3.Visible = false; // Hides the "Ticket Status" Label
                txtAnswer.ReadOnly = true; // Hides the "Answer" RichTextBox that Admin use to answer tickets.
                TicketStatus.Visible = false; // Hides the Ticket Status ComboBox
                btnSubmit.Visible = false;  //Hides the "Submit" button admin used to answer.
                btnClose.Location = new Point(287, 590); // Set the Close bottom to the Center, to make the UI cleaner after the 
            }
                lblTicketID.Text = "Ticket ID: " + Convert.ToString(ID);
                lblDescription.Text = "Description: " + Description;
                lblTitle.Text = "Title: " + Title;
                richTextBox1.Text = Message;
                txtAnswer.Text = Answer;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer.Text) || string.IsNullOrEmpty(TicketStatus.Text)) // Makes sure every field is filled up by the admin whom answer.
            {
                MessageBox.Show("You're missing Answer or Status.", "Error");
            }
            else
            {
                using(SqlConnection con = new SqlConnection(connector.dbcon))
                {
                    Answer = DateTime.Now.ToString() + " " + LoginForm.Username + ": " + txtAnswer.Text; // Pass the answer to be updated at the SQL every time.
                    queryTickets.TicketAnswer(con, Answer, TicketStatus.Text, ID); // Execute the "Insert" command from the Database.DBQueryTickets.cs
                    MessageBox.Show("Your Answer and Status has been updated."); 
                    this.Close();
                }
            }
        }
    }
}
