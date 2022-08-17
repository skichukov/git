﻿using Game.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            UserService us = new UserService();

            if(us.HasUser(usernameTxt.Text, passwordTxt.Text))
            {
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Проверете Вашето потребителско име и парола!");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            this.Hide();
            rf.Show();
        }
    }
}