using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Manage;

namespace LibraryManagementSystem
{
    public partial class WorkerDashboard : Form
    {
        string connection = "Data Source=MATAN-235;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=true";
        public WorkerDashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void WorkerDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.librarySystemDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE \"Book Name\" LIKE @bookname", con);
                    var Text = "%" + textBox1.Text + "%";
                    command.Parameters.AddWithValue("@bookname", Text);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                    textBox1.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }   
            }            
        }

        private void rentedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentedBooksUI rentedBooksUI = new RentedBooksUI();
            rentedBooksUI.ShowDialog();
        }

        private void availableBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableBooksUI availableBooksUI = new AvailableBooksUI();
            availableBooksUI.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersUI customersUI = new CustomersUI();   
            customersUI.ShowDialog();
        }

        private void newBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewBookUI newBookUI = new NewBookUI();
            newBookUI.ShowDialog();
        }
        public void DataBind()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("select * from Books", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sd.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void newRenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBookRentUI newBookRentUI = new NewBookRentUI();
            newBookRentUI.ShowDialog();
        }

        private void remvoeRenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBookUI removeBookUI = new RemoveBookUI();
            removeBookUI.Show();
        }

        private void removeRenterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveBookRentUI remvoeRentUI = new RemoveBookRentUI();
            remvoeRentUI.Show();
        }
    }
}
