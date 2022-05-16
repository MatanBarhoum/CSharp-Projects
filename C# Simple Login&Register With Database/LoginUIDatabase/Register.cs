using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginUIDatabase
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MATAN-235;Initial Catalog=LoginTest;Integrated Security=True");

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into LoginTest_Table values ('" + UsernameValue.Text + "','" + PasswordValue.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered successfully");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }    

        }
    }
}
