using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class CustomersUI : Form
    {
        static string constring = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static string cmd = "SELECT * FROM LibraryAccounts";
        public CustomersUI()
        {
            InitializeComponent();
        }

        private void CustomersUI_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    SqlCommand command = new SqlCommand(cmd, con);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    var id = "ID";
                    var username = "Username";
                    var password = "Password";
                    var createdAt = "CreatedAt";
                    var isworker = "IsWorker";
                    table.Columns.Remove(id);
                    table.Columns.Remove(username);
                    table.Columns.Remove(password);
                    table.Columns.Remove(createdAt);
                    table.Columns.Remove(isworker);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
