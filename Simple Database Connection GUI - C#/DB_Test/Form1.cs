using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K2GN5U0;Initial Catalog=TutorialDB;Integrated Security=True");
        private void InsertButton_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ProductInfo_Table values ('"+int.Parse(ProductIDButton.Text)+ "','" + ItemNameButton.Text + "','" + DesignButton.Text + "','" + ColorButton.Text + "', getdate())", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
            DataBind();
        }

        void DataBind()
        {
            SqlCommand cmd = new SqlCommand("select * from ProductInfo_Table", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sd.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
