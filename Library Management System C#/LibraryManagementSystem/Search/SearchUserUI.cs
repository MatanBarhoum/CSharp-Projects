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
using LibraryManagementSystem;

namespace LibraryManagementSystem.Search
{

    public partial class SearchUserUI : Form
    {
        string connection = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";

        public SearchUserUI()
        {
            InitializeComponent();
        }

        private void SearchUserUI_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM LibraryAccounts WHERE \"FullName\" LIKE @searchValue", con);
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
                    table.Columns.Remove("ID");
                    table.Columns.Remove("Username");
                    table.Columns.Remove("Password");
                    table.Columns.Remove("CreatedAt");
                    table.Columns.Remove("isworker");
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
