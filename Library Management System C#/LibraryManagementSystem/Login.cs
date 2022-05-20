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
    public partial class Login : Form
    {
        private static string connection = "Data Source=MATAN-235;Initial Catalog = LibrarySystem; Integrated Security = True";
        SqlConnection con = new SqlConnection(connection);
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select * from LibraryAccounts where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", UsernameValue.Text);
                cmd.Parameters.AddWithValue("@password", PasswordValue.Text);
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var UserWorkerID = reader["isworker"].ToString();
                    if (UserWorkerID == "1")
                    {
                        MessageBox.Show("Successfully logged in User.", "Logged in");
                    } 
                    else if (UserWorkerID == "2")
                    {
                        Program.OpenDetailFormOnClose = true;
                        this.Close();
                        WorkerDashboard Dashboard = new WorkerDashboard();
                        Dashboard.ShowDialog();
                    }
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
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
