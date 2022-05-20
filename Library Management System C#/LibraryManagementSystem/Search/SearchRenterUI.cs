using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Manage;

namespace LibraryManagementSystem.Search
{
    public partial class SearchRenterUI : Form
    {
        string connection = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        public SearchRenterUI()
        {
            InitializeComponent();
        }

        private void SearchRenterUI_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM RentedBooks WHERE userHas LIKE @searchValue", con);
                    if (RemoveBookRentUI.SearchIndex == 0)
                    {
                        var Text = "%" + NewBookRentUI.SearchUser + "%";
                        MessageBox.Show(Text);
                        command.Parameters.AddWithValue("@searchValue", Text);
                    }
                    else if (RemoveBookRentUI.SearchIndex == 1)
                    {
                        string Text = "%" + RemoveBookRentUI.SearchUser + "%";
                        MessageBox.Show(Text);
                        command.Parameters.AddWithValue("@searchValue", Text);
                        RemoveBookRentUI.SearchIndex--;
                    }

                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    table.Columns["userHas"].ColumnName = "Full Name";
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
