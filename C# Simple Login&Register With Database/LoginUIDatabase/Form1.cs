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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlDataReader reader = null;
        public static string Constring = "Data Source=MATAN-235;Initial Catalog=LoginTest;Integrated Security=True";
        SqlConnection con = new SqlConnection(Constring);
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try 
            {
                
                SqlCommand cmd = new SqlCommand("select * from logintest_table where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", UsernameValue.Text);
                cmd.Parameters.AddWithValue("@password", PasswordValue.Text);
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Successfully logged in.", "Logged in");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Warning");
                }



            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
        }
    }
}
