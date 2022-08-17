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
    public partial class MainForm : Form
    {
        UserService us = new UserService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            foreach(User user in us.GetUsers())
            {
                //user.ToString();
                listWithUsers.Items.Add(user);
            }
            
            listWithUsers.Show();
        }

        private void lOutStripTextBox_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
            Game.Properties.Settings.Default.Save();
        }
    }
}
