using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BugTracker.Database;
using System.Threading;

namespace BugTracker.Handlers
{
    public class LoginHandler
    {
        private readonly DBConnector _connector; // private onlyread field, then calling it from the constructor.
        public bool hasAuth = false;
        public bool isAdmin { get; set; }
        public LoginHandler(DBConnector connector) // calling the _connector private field.
        {
            this._connector = connector; // settings the field wit the DBConnector.
        }

        /* Using command and reader check if the user exist or not, then set the bool and this used to load admin or user. (using IsAdmin 0 or 1) in the database. */
        public void ValidateUser(string username, string password)
        {
            var checkCMD = "SELECT Username, Password, Admin FROM Accounts WHERE username=@username and password=@password";

            using (var conn = new SqlConnection(_connector.dbcon))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(checkCMD, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    _connector.OpenDB(conn);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["username"].ToString().ToLower() == username.ToLower() && reader["password"].ToString().ToLower() == password.ToLower() && reader["Admin"].ToString() == "1")
                        {
                            // Login Success as Admin -- BugsForm
                            hasAuth = true;
                            isAdmin = true;
                        }
                        else if (reader["username"].ToString().ToLower() == username.ToLower() && reader["password"].ToString().ToLower() == password.ToLower() && reader["Admin"].ToString() == "0")
                        {
                            //Login Success as Reporter -- BugsReport 
                            hasAuth = true;
                            isAdmin = false;
                        }
                    }
                    if (!hasAuth)
                    {
                        MessageBox.Show("Username or Password incorrect.", "Login Error");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured");
                }

                finally
                {
                    _connector.CloseDB(conn);
                }

            }
        }
    }
}
