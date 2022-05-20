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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        
        static string con = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static public string cmdReg = "insert into LibraryAccounts values(@username,@password,1,getdate(),@fullname,@telephone,@email)";
        static public string cmdCheck = "select username from LibraryAccounts";
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterValue_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(con)) 
            {
                try
                {

                    if (string.IsNullOrEmpty(UsernameValue.Text))
                    {
                        MessageBox.Show("Username is required.");
                    }
                    else if (string.IsNullOrEmpty(PasswordValue.Text))
                    {
                        MessageBox.Show("Password is Required.");
                    }
                    else if (string.IsNullOrEmpty(FullNameValue.Text))
                    {
                        MessageBox.Show("Full Name is required.");
                    }
                    else if (string.IsNullOrEmpty(TelephoneValue.Text))
                    {
                        MessageBox.Show("Telephone is required.");
                    }
                    else if (string.IsNullOrEmpty(EmailValue.Text))
                    {
                        MessageBox.Show("Email is required.");
                    }
                    else
                    {
                        SqlCommand cmdcheck = new SqlCommand(cmdCheck, connection);
                        connection.Open();
                        SqlDataReader reader = cmdcheck.ExecuteReader();
                        var usernameExist = "no";
                        while (reader.Read())
                        {
                            if (reader["username"].ToString() == UsernameValue.Text)
                            { 
                                usernameExist = "yes";
                            }
                        }
                        if (usernameExist == "yes")
                        {
                            MessageBox.Show("Username already exist.");
                        }
                        else
                        {
                            SqlCommand command = new SqlCommand(cmdReg, connection);
                            command.Parameters.AddWithValue("@username", UsernameValue.Text);
                            command.Parameters.AddWithValue("@password", PasswordValue.Text);
                            command.Parameters.AddWithValue("@fullname", FullNameValue.Text);
                            command.Parameters.AddWithValue("@telephone", TelephoneValue.Text);
                            command.Parameters.AddWithValue("@email", EmailValue.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Succssefully Registered. You can now login.");
                            this.Close();
                        }
                    }
                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }

                finally
                {
                    connection.Close();

                }

            }
                

            }
        }
    }

