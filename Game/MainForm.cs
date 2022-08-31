﻿using Game.Models;
using Game.Services;
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
    public partial class MainForm : Form
    {
        List_Users lu = new List_Users();
        LoginForm lf = new LoginForm();
        Constants c = Constants.GetConstants();
        UserService us;
        User loggedUser;

        public MainForm()
        {
            InitializeComponent();
            us = c.GetUserService();
            loggedUser = c.GetCurrentUser();
        }

        private void viewUsersTextBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            lu.Show();
        }

        private void lOutStripTextBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            lf.Show();
            Game.Properties.Settings.Default.Save();
        }

        private void updtStripTextBox_Click(object sender, EventArgs e)
        {
            UpdateUserForm update = new UpdateUserForm();
            this.Hide();
            update.Show();

            update.Print();
        }

        private void CreateHeroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateHero ch = new CreateHero();
            ch.Show();
        }

        private void deleteTextBox_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Сигурни ли сте, че искате да изтриете профила си?",
               "Изисква се потвърждение", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                us.DeleteUser(loggedUser);
                this.Hide();
                lf.Show();
            }
            
            
        }
    }
}
