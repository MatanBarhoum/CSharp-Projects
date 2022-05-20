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
    public partial class NewBookUI : Form
    {

        static string con = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static public string cmdNewBook = "insert into Books values(@BookID,@BookName,@Available,@Quantity,@is_rented,@price,@category)";
        static public string cmdBookCheck = "select \"Book Name\", \"Book ID\" from Books";

        public NewBookUI()
        {
            InitializeComponent();
        }

        private void NewBookUI_Load(object sender, EventArgs e)
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
                    else if (string.IsNullOrEmpty(AvailableDropdown.Text))
                    {
                        MessageBox.Show("Status is required.");
                    }
                    else if (string.IsNullOrEmpty(QuantityValue.Text))
                    {
                        MessageBox.Show("Quantity is required.");
                    }
                    else if (string.IsNullOrEmpty(RentedDroplist.Text))
                    {
                        MessageBox.Show("Rent status is required.");
                    }
                    else if (string.IsNullOrEmpty(PriceValue.Text))
                    {
                        MessageBox.Show("Price is required");
                    }
                    else if (string.IsNullOrEmpty(CategoryDroplist.Text))
                    {
                        MessageBox.Show("Category is required");
                    }
                    else
                    {
                        SqlCommand cmdcheck = new SqlCommand(cmdBookCheck, connection);
                        connection.Open();
                        SqlDataReader reader = cmdcheck.ExecuteReader();
                        var BookExist = "no";
                        while (reader.Read())
                        {
                            if (reader["Book Name"].ToString() == BookNameValue.Text || reader["Book ID"].ToString() == BookIDValue.Text)
                            {
                                BookExist = "yes";
                            }
                        }
                        if (BookExist == "yes")
                        {
                            MessageBox.Show("Book ID or Book Name already exist.");
                        }
                        else
                        {
                            var bookID = Convert.ToInt32(BookIDValue.Text);
                            var quantity = Convert.ToInt32(QuantityValue.Text);
                            var price = Convert.ToInt32(PriceValue.Text);
                            SqlCommand cmd = new SqlCommand(cmdNewBook, connection);
                            cmd.Parameters.AddWithValue("@BookID", bookID);
                            cmd.Parameters.AddWithValue("@BookName", BookNameValue.Text);
                            cmd.Parameters.AddWithValue("@Available", AvailableDropdown.Text);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@is_rented", RentedDroplist.Text);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@category", CategoryDroplist.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Succssefully added book.");
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

            }
        }
    
