using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static double result { get; set; }
        public static double roundedResult { get; set; }

        public static bool notpassed = true;
        public void submitButton_Click(object sender, EventArgs e)
        {
            CheckRequirements();
            if (notpassed)
            {
                return;
            }
            else
            {
                double mass = Convert.ToDouble(weightValue.Text);
                double height = Convert.ToDouble(heightValue.Text);
                result = mass / (height * height);
                roundedResult = Math.Round(result, 1);

                if (roundedResult <= 16.0)
                {
                    resultValue.ForeColor = Color.Red;
                    resultValue.Text = "Severe thinness";
                }
                else if (roundedResult > 16.0 && roundedResult <= 16.9)
                {
                    resultValue.ForeColor = Color.Red;
                    resultValue.Text = "Moderate thinness";
                }
                else if (roundedResult >= 17.0 && roundedResult <= 18.4)
                {
                    resultValue.ForeColor = Color.Red;
                    resultValue.Text = "Mild thinness";
                }
                else if (roundedResult >= 18.5 && roundedResult <= 24.9)
                {
                    resultValue.ForeColor = Color.Green;
                    resultValue.Text = "Normal";
                }
                else if (roundedResult >= 25.0 && roundedResult <= 29.9)
                {
                    resultValue.ForeColor = Color.Orange;
                    resultValue.Text = "Overweight";
                }
                else if (roundedResult > 30.0)
                {
                    resultValue.ForeColor = Color.Red;
                    resultValue.Text = "Obese";
                }
            }
        }

        public void CheckRequirements()
        {
            if (string.IsNullOrEmpty(heightValue.Text) ||
                string.IsNullOrEmpty(weightValue.Text) ||
                string.IsNullOrEmpty(ageValue.Text))
            {
                MessageBox.Show("One or more rows are empty.", "Warning!");
            }
            else
            {
                notpassed = false;
            }
        }
    }
}

