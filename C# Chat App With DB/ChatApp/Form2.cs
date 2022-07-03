using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;


namespace ChatApp
{
    public partial class LoginForm : Form
    {
        public static string Username { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConnect;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DBConnector.constring))
            {
                try
                {
                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        MessageBox.Show("Username is required.");
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Password is Required.");
                    }
                    else
                    {
                        string querycmd = "select * from login_table where username=@username and password=@password";
                        SqlCommand cmd = new SqlCommand(querycmd, conn);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            
                            if (reader["username"].ToString() == txtUsername.Text)
                            {
                                Username = reader["username"].ToString();
                                MessageBox.Show("Welcome " + Username);
                                Thread AppLoad = new Thread(new ThreadStart(LoadApp));
                                this.Hide();
                                AppLoad.Start();
                                this.Close();
                            }
                            reader.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Warning");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        private void LoadRegister()
        {
            Register register = new Register();
            register.ShowDialog();   
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Thread Register = new Thread(new ThreadStart(LoadRegister));
            this.Hide();
            Register.Start();
            this.Close();
        }

        private void LoadApp()
        {
            ChatApp app = new ChatApp();
            app.ShowDialog();
        }
    }
}

