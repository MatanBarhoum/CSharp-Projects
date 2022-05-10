using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form1 : Form
    {
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private FontDialog FontDialog;
        public Form1()
        {
            InitializeComponent();
        }

        private void NewFile()
        {
            try 
            { 
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    if (MessageBox.Show("Are you sure you want to continue without saving your file?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.richTextBox1.Text = string.Empty;
                        this.Text = "Untitled";
                    }
    
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            { 

            }
            finally 
            {

            }
        }

        private void SaveNewFile()
        {
            try 
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    SaveFileDialog SaveFile = new SaveFileDialog();
                    SaveFile.Filter = "Text (*.txt)|*.txt|Word Doc (*.word)|*.word";
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFile.FileName, this.richTextBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show("There's no text in the file!");
                }
            }
            catch (Exception ex)
            { 

            }
            finally 
            {

            }

        }

        private void OpenNewFile()
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                var textinfile = File.ReadAllText(openFile.FileName);
                this.Text = openFile.FileName;
                this.richTextBox1.Text = textinfile;
            }
            catch (Exception ex)
            {

            }
            finally { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog = new FontDialog();
            FontDialog.ShowDialog();
            richTextBox1.Font = FontDialog.Font;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNewFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
