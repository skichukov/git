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
    public partial class LoginForm : Form
    {
        Constants c = Constants.GetConstants();
        UserService us;

        public LoginForm()
        {
            InitializeComponent();
            us = c.GetService();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTxt.Text != "" && passwordTxt.Text != "")
            {
                MainForm mf = new MainForm();

                if(us.HasUserWith(usernameTxt.Text, passwordTxt.Text))
                {
                    this.Hide();
                    mf.Show();
                    us.SaveUser(usernameTxt.Text, passwordTxt.Text);
                }
                else
                {
                    MessageBox.Show("Проверете Вашето потребителско име и парола!");
                }
            }
            else
            {
                MessageBox.Show("Въведете потребителско име и парола!");

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
