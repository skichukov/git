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
    public partial class CreateBattle : Form
    {
        User loggedUser;
        HeroeService hs;
        Constants c = Constants.GetConstants();

        public CreateBattle()
        {
            InitializeComponent();
            loggedUser = c.GetCurrentUser();
            hs = c.GetHeroeService();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(SetCloseOperation);
        }

        private void SetCloseOperation(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cHARACTERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHARACTERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameDbDataSet);

        }

        private void List_Heroes_Load(object sender, EventArgs e)
        {
            this.cHARACTERSTableAdapter.Fill(this.gameDbDataSet.CHARACTERS, loggedUser.Id);
            this.cHARACTERSTableAdapter.Connection.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        public int abs(int a)
        {
            int result;
            if(a < 0)
            {
                result = -a;
            }
            else
            {
                result = a;
            }

            return result;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Character hero_1 = hs.GetHeroById((int)iDComboBox.SelectedValue);
            Character hero_2 = hs.GetHeroById((int)iDComboBox1.SelectedValue);
            Random r = new Random();
            int health_upd;

            Battle b = new Battle
            {
                UserId = loggedUser.Id,
                DateCreated = DateTime.Now,
                Organiser = loggedUser
            };

            while((hero_1.HealthPoints > 0) && (hero_2.HealthPoints > 0))
            {
                int rand = r.Next(-5, 5);
                int new_attack = hero_1.AttackPoints + rand;
                hero_1.AttackPoints = new_attack;
                int difference = abs(hero_1.AttackPoints - hero_2.DefencePoints);
                if(hero_1.AttackPoints > hero_2.DefencePoints)
                {
                    health_upd = hero_2.HealthPoints - difference;
                    hero_2.HealthPoints = health_upd;
                    MessageBox.Show("Атаката на " + hero_1.CharacterName + " става " 
                        + hero_1.AttackPoints +  " Защитата на " + hero_2.CharacterName + 
                        " e " + hero_2.DefencePoints);
                }
                else
                {
                    health_upd = hero_1.HealthPoints - difference;
                    hero_1.HealthPoints = health_upd;
                    MessageBox.Show("Атаката на " + hero_1.CharacterName + " става "
                        + hero_1.AttackPoints + " Защитата на " + hero_2.CharacterName +
                        " e " + hero_2.DefencePoints);
                }
            }

            _ = (hero_1.HealthPoints > 0) ? (b.Winner = hero_1, b.Loser = hero_2) : (b.Winner = hero_2, b.Loser = hero_1);
        }
    }
}
