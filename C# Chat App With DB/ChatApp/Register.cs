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
    public partial class Register : Form
    {
        public static bool hasRegistered { get; set; }
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(DBConnector.constring))
            {
                try
                {
                    conn.Open();
                    string cmdReg = "insert into login_table values(@username,@password)";
                    string cmdCheck = "select username from login_table";

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
                        SqlCommand cmdcheck = new SqlCommand(cmdCheck, conn);
                        SqlDataReader reader = cmdcheck.ExecuteReader();
                        var usernameExist = "no";
                        while (reader.Read())
                        {
                            if (reader["username"].ToString() == txtUsername.Text)
                            {
                                usernameExist = "yes";
                                break;
                            }
                        }
                        if (usernameExist == "yes")
                        {
                            MessageBox.Show("Username already exist.");
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand(cmdReg, conn);
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Succssefully Registered. You can now login.");

                        }        

                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void LoadLogin()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Thread Login = new Thread(new ThreadStart(LoadLogin));
            this.Hide();
            Login.Start();
            this.Close();
        }
    }
    }
