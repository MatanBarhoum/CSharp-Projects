using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public static string DataForForm2;
        public static int ID = 0;
        //reset auto_incerement == DBCC CHECKIDENT (ReportSystem_Table4, RESEED, 0)
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MATAN-235;Initial Catalog=DB_ReportSystem;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleTextBox.Clear();
            MessageTextBox.Clear();
            ImageTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTextBox.Text) || string.IsNullOrEmpty(MessageTextBox.Text)) { MessageBox.Show("Empty note."); }
            else { 
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ReportSystem_Table4 values ('" + TitleTextBox.Text + "','" + MessageTextBox.Text + "', '"+ ImageTextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added to DB.");
                con.Close();
                DataBind();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    SqlCommand cmd = new SqlCommand("select * from ReportSystem_Table4", con);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    sd.Fill(table);
                    dataGridView1.DataSource = table;
                    TitleTextBox.Text = table.Rows[index]["Title"].ToString();
                    MessageTextBox.Text = table.Rows[index]["Message"].ToString();
                    ImageTextBox.Text = table.Rows[index]["Image"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("There's 0 notes.", "Warning"); }
            finally { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            SqlCommand cmd = new SqlCommand("select * from ReportSystem_Table4", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            dataGridView1.DataSource = table;
            var title = table.Rows[index]["Title"].ToString();
            String st = "DELETE FROM ReportSystem_Table4 WHERE Title = \'" + title + "\'";
            SqlCommand sqlcom = new SqlCommand(st, con);

            try
            {
                con.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("delete successful");
                table.Rows[index].Delete();
                TitleTextBox.Clear();
                MessageTextBox.Clear();
                ImageTextBox.Clear();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile;
            openfile = new OpenFileDialog();
            openfile.Filter = ("JPG|*.jpg|JPEG|*.jpeg|PNG|*.png");
            openfile.ShowDialog();
            ImageTextBox.Text = openfile.FileName;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataForForm2 = ImageTextBox.Text;
            Form2 form = new Form2();
            form.ShowDialog();
        }

        public void DataBind()
        {
            SqlCommand cmd = new SqlCommand("select * from ReportSystem_Table4", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
