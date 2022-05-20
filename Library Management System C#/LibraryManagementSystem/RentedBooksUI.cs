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
    public partial class RentedBooksUI : Form
    {
        static string con = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static string cmd = "SELECT * FROM RentedBooks";
        public RentedBooksUI()
        {
            InitializeComponent();
        }

        private void RentedBooksUI_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    table.Columns["userHas"].ColumnName = "Renter";
                    dataGridView1.DataSource = table;
                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
