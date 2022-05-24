using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public static int gravity = 3;
        public static int pipespeed = 4;
        public static int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Speed(int score)
        {
            if (score % 5 == 0 && score != 0 )
            {
                pipespeed += 2;
            }

        }
        private void GameIsTick(object sender, EventArgs e)
        {
            Random rand = new Random();
            var newRandom = rand.Next(380, 430);
            FlappyBird.Top += gravity;
            pipeDown.Left -= pipespeed;
            pipeUp.Left -= pipespeed;
            label2.Text = String.Format("{0}", pipespeed);

            if (pipeDown.Left < -150)
            {
                pipeDown.Left += newRandom;
            }

            if (pipeUp.Left < -200)
            {
                pipeUp.Left += newRandom;
                score++;
                label1.Text = String.Format("Score: {0}", score);
                Speed(score);
            }

            if (FlappyBird.Bounds.IntersectsWith(pipeDown.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeUp.Bounds) || FlappyBird.Bounds.IntersectsWith(Ground.Bounds))
            {
                GameTimer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -3;
            }
        }
       

    private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 3;
            }
        }

    }
}
