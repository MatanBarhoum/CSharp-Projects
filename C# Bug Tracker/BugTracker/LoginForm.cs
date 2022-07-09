using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BugTracker.Database;
using BugTracker.Handlers;
using System.Threading;

namespace BugTracker
{
    public partial class LoginForm : Form
    {
        public static string Username { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var _connector = new DBConnector();
            var _userUI = new UserUI();
            var _handler = new LoginHandler(_connector);
            _handler.ValidateUser(txtUsername.Text, txtPassword.Text);
            Username = txtUsername.Text;
            if (_handler.hasAuth == true)
            {
                if (_handler.isAdmin != true)
                {
                    StartUserUI();
                }
                else
                {
                    StartAdminUI();
                }
            }
        }

        private void chkLightMode_Click(object sender, EventArgs e)
        {
            SwitchMode();
        }

        private void SwitchMode()
        {
            if (chkLightMode.Checked)
            {
                this.BackColor = Color.White;
                lblUsername.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                Logo.Image = global::BugTracker.Properties.Resources.ForWhite;
                btnLogin.BackColor = Color.FromArgb(24, 24, 24);
                btnLogin.ForeColor = Color.White;
                lblReport.ForeColor = Color.Black;
                chkLightMode.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(24, 24, 24);
                lblUsername.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
                Logo.Image = global::BugTracker.Properties.Resources.LogoMakr_5AXvGR;
                btnLogin.BackColor = Color.White;
                btnLogin.ForeColor = Color.FromArgb(24, 24, 24);
                lblReport.ForeColor = Color.White;
                chkLightMode.ForeColor = Color.White;
            }
        }

        private void LoadAdminUI()
        {
            AdminUI adminUI = new AdminUI();
            adminUI.ShowDialog();
        }

        private void StartAdminUI()
        {
            Thread startAdminUI = new Thread(new ThreadStart(LoadAdminUI));
            this.Hide();
            startAdminUI.Start();
            this.Close();
        }

        private void LoadUserUI()
        {
            UserUI userUI = new UserUI();
            userUI.ShowDialog();
        }

        private void StartUserUI()
        {
            Thread startUserUI = new Thread(new ThreadStart(LoadUserUI));
            this.Hide();
            startUserUI.Start();
            this.Close();
        }
    }
}
