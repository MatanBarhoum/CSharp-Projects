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
    public partial class AvailableBooksUI : Form
    {
        static string constring = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static string cmd = "SELECT * FROM Books WHERE Available = 'Yes'";
        public AvailableBooksUI()
        {
            InitializeComponent();
        }

        private void AvailableBooksUI_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    var id = "ID";
                    var rented = "is_rented";
                    table.Columns.Remove(id);
                    table.Columns.Remove(rented);
                    dataGridView1.DataSource = table;
                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
