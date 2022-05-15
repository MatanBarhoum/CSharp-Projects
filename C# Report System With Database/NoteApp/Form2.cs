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

    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = Image.FromFile(Form1.DataForForm2);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { MessageBox.Show("There is no image loaded");  }
            
            
        }
    }
}
