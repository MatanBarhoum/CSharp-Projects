using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public static string DataForForm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));
            table.Columns.Add("Image", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text)) { MessageBox.Show("Empty note."); }
            else {
                table.Rows.Add(textBox1.Text, richTextBox1.Text, textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    textBox1.Text = table.Rows[index].ItemArray[0].ToString();
                    richTextBox1.Text = table.Rows[index].ItemArray[1].ToString();
                    textBox2.Text = table.Rows[index].ItemArray[2].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("There's 0 notes.", "Warning"); }
            finally { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch (Exception ex) { }
            finally { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile;
            openfile = new OpenFileDialog();
            openfile.Filter = ("JPG|*.jpg|JPEG|*.jpeg|PNG|*.png");
            openfile.ShowDialog();
            textBox2.Text = openfile.FileName;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataForForm2 = textBox2.Text;
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
