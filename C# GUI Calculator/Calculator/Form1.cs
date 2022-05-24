using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public int firstNumber { get; set; }
        public int secNumber { get; set; }
        public static double number1 { get; set; }
        public static double number2 { get; set; }
        public static string Operator { get; set; }
        public bool Calculated { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("1");
            
        }
        private void twoButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("2");
            
        }
        private void threeButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("3");
            

        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("4");
            
        }
        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("5");

        }
        private void sixButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("6");

        }
        private void sevenbutton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("7");

        }
        private void eightButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }

                CalcBox.AppendText("8");
            
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }
                CalcBox.AppendText("9");
        }
        private void zerobutton_Click(object sender, EventArgs e)
        {
            if (Calculated == true)
            {
                Calculated = false;
                Opcount = 0;
                CalcBox.Clear();
                label1.Text = "";
            }
            else
            {
                CalcBox.AppendText("0");
            }
        }
        private void clearbutton_Click(object sender, EventArgs e)
        {
            CalcBox.Clear();
            label1.Text = "";
            Opcount = 0;
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CalcBox.Text))
            {
                CalcBox.Text = CalcBox.Text.Remove(CalcBox.Text.Length - 1, 1);
                if (string.IsNullOrEmpty(CalcBox.Text))
                {
                    Opcount = 0;
                }
            }
            else
            {
                Opcount = 0;
                return;
            }
        }

        public static int Opcount = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(CalcBox.Text);
                if (Opcount == 1)
                {
                    MessageBox.Show("Can't hold more than 1 operator.");
                }
                else
                {
                    CalcBox.AppendText("+");
                    Opcount = 1;
                    Operator = "+";
                }
                label1.Text = string.Format("{0} {1}", firstNumber, Operator);
                label1.Visible = true;
                CalcBox.Clear();
            }
            catch (Exception) { }
        }
        private void substractbutton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(CalcBox.Text);
                if (Opcount == 1)
                {
                    MessageBox.Show("Can't hold more than 1 operator.");
                }
                else
                {
                    CalcBox.AppendText("-");
                    Opcount = 1;
                    Operator = "-";
                }
                label1.Text = string.Format("{0} {1}", firstNumber, Operator);
                label1.Visible = true;
                CalcBox.Clear();
            }
            catch (Exception) { }
        }
        private void dividebutton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(CalcBox.Text);
                if (Opcount == 1)
                {
                    MessageBox.Show("Can't hold more than 1 operator.");
                }
                else
                {
                    CalcBox.AppendText("/");
                    Opcount = 1;
                    Operator = "/";
                }
                label1.Text = string.Format("{0} {1}", firstNumber, Operator);
                label1.Visible = true;
                CalcBox.Clear();
            }
            catch (Exception) { }
        }
        private void multiplebutton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(CalcBox.Text);
                if (Opcount == 1)
                {
                    MessageBox.Show("Can't hold more than 1 operator.");
                }
                else
                {
                    CalcBox.AppendText("*");
                    Opcount = 1;
                    Operator = "*";
                }
                label1.Text = string.Format("{0} {1}", firstNumber, Operator);
                label1.Visible = true;
                CalcBox.Clear();
            }
            catch (Exception) { }
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                secNumber = Convert.ToInt32(CalcBox.Text);
                var Result = Math.Round(Calc(firstNumber, secNumber), 3);
                if (Result == 112233)
                {
                    MessageBox.Show("Cannot Divide by Zero!!!!");
                    CalcBox.Text = "Error";
                    Calculated = true;
                }
                else
                {
                    CalcBox.Text = String.Format("{0}", Result);
                    Calculated = true;
                }
                label1.Text = string.Format("{0} {1} {2} =", firstNumber, Operator, secNumber);
                label1.Visible = true;
                Calculated = true;
            }
            catch (Exception) { }
        }

        public double Calc(int Number1, int Number2)
        {
            number1 = Number1;
            number2 = Number2;
            switch (Operator)
            {
                case "+":
                    {
                        return number1 + number2;
                    }
                case "-":
                    {
                        return number1 - number2;
                    }
                case "/":
                    {
                        try
                        {
                            if (secNumber == 0 && Operator == "/")
                            {
                                return 112233;
                            }
                            else {
                                return number1 / number2;
                            }
                        }
                        catch (Exception e){ return 0; }
                    }
                case "*":
                    {
                        return number1 * number2;
                    }
                default:
                    {
                        return 1;
                    }
            } 
        }
    }
}
