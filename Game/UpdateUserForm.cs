using Game.Models;
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
    public partial class UpdateUserForm : Form
    {
        UserService us = new UserService();
        MainForm mf = new MainForm();
        User current_user;

        public UpdateUserForm()
        {
            InitializeComponent();
            current_user = us.GetCurrentUser();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mf.Show();
        }

        public void Print()
        {
            txtBox_name.Text = us.GetCurrentUser().Name;
            txtBox_username.Text = us.GetCurrentUser().Username;
            txtBox_pass.Text = us.GetCurrentUser().Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            us.GetCurrentUser().Name = txtBox_name.Text;
            us.GetCurrentUser().Username = txtBox_username.Text;
            us.GetCurrentUser().Password = txtBox_pass.Text;

            us.UpdateUser(current_user);
            this.Hide();
            mf.Show();
        }
    }
}
