using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem;
using System.Data.SqlClient;
using LibraryManagementSystem.Manage;
using LibraryManagementSystem.Search;

namespace LibraryManagementSystem.Manage
{
    public partial class NewBookRentUI : Form
    {
        static string con = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        static public string cmdNewBook = "insert into RentedBooks values(@BookID,@BookName,@userHas)";
        static public string cmdBookCheck = "select \"Book Name\", \"Book ID\" from Books";
        static public string cmdUserCheck = "select \"FullName\" from LibraryAccounts";
        static public string cmdUpdate = "UPDATE Books SET is_rented = @rented Where \"Book Name\" = @BookName";
        static public string cmdUpdateQuantity = "UPDATE Books SET quantity = quantity - 1 WHERE \"Book Name\" = @BookName";
        static public string BookExist = "no";
        static public string SearchUser = "";
        static public string SearchBook = "";
        public NewBookRentUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewBookRentUI_Load(object sender, EventArgs e)
        {

        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            SearchUser = SearchUserValue.Text;
            
            SearchUserUI searchUserUI = new SearchUserUI();
            searchUserUI.Show();
            this.Show();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                try 
                {
                    if (string.IsNullOrEmpty(BookIDValue.Text)) 
                    {
                        MessageBox.Show("Please enter Book ID.");
                    }

                    else if (string.IsNullOrEmpty(BooknameValue.Text)) 
                    {
                        MessageBox.Show("Please enter Book Name");
                    }
                    else if (string.IsNullOrEmpty(UserHasvalue.Text))
                    {
                        MessageBox.Show("Please enter Full name");
                    }
                    else
                    {
                        SqlCommand cmdcheck = new SqlCommand(cmdBookCheck, conn);
                        SqlDataReader reader = cmdcheck.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            if (reader["Book Name"].ToString() == BooknameValue.Text && reader["Book ID"].ToString() == BookIDValue.Text)
                            {
                                BookExist = "yes";
                            }
                        }
                        if (BookExist == "no")
                        {
                            MessageBox.Show("Book ID or Book Name not exist.");
                        }
                    }
                    SqlCommand cmdcheck1 = new SqlCommand(cmdUserCheck, conn);
                    SqlDataReader reader1 = cmdcheck1.ExecuteReader();
                    var UserExist = "no";
                    while (reader1.Read())
                    {
                        if (reader1["FullName"].ToString() == UserHasvalue.Text)
                        {
                            UserExist = "yes";
                        }
                    }

                    if (UserExist == "no" && !string.IsNullOrEmpty(UserHasvalue.Text))
                    {
                        MessageBox.Show("User not exist.");
                    }
                    if (UserExist == "yes" && BookExist == "yes")
                    {
                        var bookID = Convert.ToInt32(BookIDValue.Text);
                        SqlCommand cmd = new SqlCommand(cmdNewBook, conn);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@BookName", BooknameValue.Text);
                        cmd.Parameters.AddWithValue("@userHas", UserHasvalue.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand Updatecmd = new SqlCommand(cmdUpdate, conn);
                        Updatecmd.Parameters.AddWithValue("@rented", "yes");
                        Updatecmd.Parameters.AddWithValue("@BookName", BooknameValue.Text);
                        Updatecmd.ExecuteNonQuery();


                        SqlCommand cmdUpdatequantity = new SqlCommand(cmdUpdateQuantity, conn);
                        cmdUpdatequantity.Parameters.AddWithValue("@BookName", BooknameValue.Text);
                        cmdUpdatequantity.ExecuteNonQuery();
                        MessageBox.Show("Succsesfully added.");
                        this.Close();
                    }


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { 
                    conn.Close();
                    
                }
            }
        }
    }
}
