using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Game.Data;
using Game.Services;

namespace Game
{
    public partial class RegistrationForm : Form
    {
        bool isLoggedIn = false;
        Constants c = Constants.GetConstants();
        UserService us;

        public RegistrationForm()
        {
            InitializeComponent();
            us = c.GetUserService();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(SetCloseOperation);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (passwordBox1.Text == passwordBox2.Text)
            {
                MainForm mf = new MainForm();
                us.InsertUser(nameBox.Text, usernameBox.Text, passwordBox2.Text);
                us.SaveUser(usernameBox.Text, passwordBox2.Text);

                this.Hide();
                mf.Show();
                isLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Въведете еднакви пароли!");
            }
        }

        private void SetCloseOperation(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
