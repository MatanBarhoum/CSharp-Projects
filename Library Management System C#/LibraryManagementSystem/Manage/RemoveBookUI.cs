using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Manage
{
    public partial class RemoveBookUI : Form
    {
        static string con = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static public string cmdDeleteBook = "DELETE FROM Books WHERE \"Book ID\" = @BookID";
        static public string cmdBookCheck = "select \"Book Name\", \"Book ID\" from Books";
        public RemoveBookUI()
        {
            InitializeComponent();
        }

        private void RemoveBookUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    if (string.IsNullOrEmpty(BookIDValue.Text))
                    {
                        MessageBox.Show("Book ID is required.");
                    }
                    else if (string.IsNullOrEmpty(BookNameValue.Text))
                    {
                        MessageBox.Show("Book Name is Required.");
                    }
                    else
                    {
                        SqlCommand cmdcheck = new SqlCommand(cmdBookCheck, connection);
                        connection.Open();
                        SqlDataReader reader = cmdcheck.ExecuteReader();
                        string BookExist = "";
                        while (reader.Read())
                        {
                            if (reader["Book Name"].ToString() == BookNameValue.Text || reader["Book ID"].ToString() == BookIDValue.Text)
                            {
                                BookExist = "yes";
                            }
                        }
                        if (BookExist == "no")
                        {
                            MessageBox.Show("Book ID or Book Name already exist.");
                        }
                        else
                        {
                            var bookID = Convert.ToInt32(BookIDValue.Text);
                            SqlCommand cmd = new SqlCommand(cmdDeleteBook, connection);
                            cmd.Parameters.AddWithValue("@BookID", bookID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Succssefully Removed book.");
                            WorkerDashboard workerDashboard = new WorkerDashboard();
                            workerDashboard.DataBind();
                            this.Close();
                        }

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { connection.Close(); }

            }
        }

        private void RentedDroplist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AvailableDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriceValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryDroplist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
