﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Game
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        string data = "Data Source=STILI\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True";
        //boolean

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (passwordBox1.Text == passwordBox2.Text)
            {
                SqlConnection s = new SqlConnection(data);
                s.Open();
                string cmd = "insert into Users (NAME, USERNAME, PASSWORD, DateCreated) " +
                    "VALUES( '" + nameBox.Text + "', '" + usernameBox.Text + "', '" +
                    passwordBox2.Text + "', CURRENT_TIMESTAMP)";
                SqlCommand command = new SqlCommand(cmd, s);
                command.ExecuteNonQuery();

                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Въведете еднакви пароли!");
            }
        }
    }
}
