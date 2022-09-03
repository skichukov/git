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
    public partial class UpdateHero : Form
    {
        HeroeService hs;
        Character hero;
        Constants c = Constants.GetConstants();
        int id_heroForUpd;

        public UpdateHero()
        {
            InitializeComponent();
            hs = c.GetHeroeService();
        }

        public void Print_Hero(int id)
        {
            id_heroForUpd = id;
            this.hero = hs.GetHeroById(id_heroForUpd);
            heroNameBox.Text = hero.CharacterName;
            attackpUpDown.Value = hero.AttackPoints;
            defpUpDown.Value = hero.DefencePoints;
            healthpUpDown.Value = hero.HealthPoints;
        }
        
        public int GetId_Hero()
        {
            return id_heroForUpd;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Character hero = new Character
            {
                Id = GetId_Hero()
            };

            hs.UpdateHero(hero);
            this.Hide();
        }
    }
}
