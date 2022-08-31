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
    public partial class CreateHero : Form
    {
        HeroeService hs;
        User loggedUser;
        Constants c = Constants.GetConstants();

        public CreateHero()
        {
            InitializeComponent();
            hs = c.GetHeroeService();
            loggedUser = c.GetCurrentUser();
        }

        private void createHeroBtn_Click(object sender, EventArgs e)
        {
            int x_1, x_2, x_3;
            //hs.InsertHero(textBox_heroName.Text, x_1, x_2, x_3, loggedUser);
            this.Hide();
        }
    }
}
