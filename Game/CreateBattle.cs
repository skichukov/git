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
        BattleService bs;
        RoundService rs;
        Constants c = Constants.GetConstants();

        public CreateBattle()
        {
            InitializeComponent();
            loggedUser = c.GetCurrentUser();
            hs = c.GetHeroeService();
            bs = c.GetBattleService();
            rs = c.GetRoundService();
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
            string[] sarray;
            string info;
            int i = 0;

            while((hero_1.HealthPoints > 0) && (hero_2.HealthPoints > 0))
            {
                i++;
                int rand = r.Next(-5, 5);
                hero_1.AttackPoints += rand;
                int difference = abs(hero_1.AttackPoints - hero_2.DefencePoints);
                if(hero_1.AttackPoints > hero_2.DefencePoints)
                {
                    hero_2.HealthPoints -= difference;
                    sarray = new string[] { 
                        "Атаката на " + hero_1.CharacterName + " става "
                        + hero_1.AttackPoints, "Защитата на " + hero_2.CharacterName +
                        " e " + hero_2.DefencePoints,
                        hero_1.CharacterName + " остава с кръв " + hero_1.HealthPoints + 
                         ", а " + hero_2.CharacterName + " - с " + hero_2.HealthPoints
                    };

                    info = String.Join("\n", sarray);
                    MessageBox.Show(info);
                }
                else
                {
                    hero_1.HealthPoints -= difference;
                    sarray = new string[] {
                        "Атаката на " + hero_1.CharacterName + " става "
                        + hero_1.AttackPoints, "Защитата на " + hero_2.CharacterName +
                        " e " + hero_2.DefencePoints,
                        hero_1.CharacterName + " остава с кръв " + hero_1.HealthPoints +
                         ", а " + hero_2.CharacterName + " - с " + hero_2.HealthPoints
                    };

                    info = String.Join("\n", sarray);
                    MessageBox.Show(info);
                }

                rs.AddRoundToList(hero_1.HealthPoints, hero_2.HealthPoints, i, rand);
            }

            if (hero_1.HealthPoints > 0) {
                hero_2.HealthPoints = 0;
                bs.InserBattle(loggedUser, hero_1, hero_2);
                hs.UpdateHero(hero_1);
                hs.UpdateHero(hero_2);
            }
            else
            {
                hero_1.HealthPoints = 0;
                bs.InserBattle(loggedUser, hero_2, hero_1);
                hs.UpdateHero(hero_1);
                hs.UpdateHero(hero_2);
            }

            Battle b = c.GetLatestBattle();
            List<Round> rounds = c.GetLocalRounds();
            for(int j = 0; j < rounds.Count; j++)
            {
                bool HasRound(Round r1)
                {
                    r1.RoundIndex = j;

                    if (rounds.Contains(r1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                Predicate<Round> match = new Predicate<Round>(HasRound);
                Round r2 = rounds.Find(match);
                rs.InsertRound(r2.Character1State, r2.Character2State, r2.RoundIndex,
                    r2.RandomNumber, b);
            }

            rs.Clear();
        }
    }
}
