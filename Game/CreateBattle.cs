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
    public partial class CreateBattle : Form
    {
        User loggedUser;
        HeroeService hs;
        BattleService bs;
        RoundService rs;
        DialogResult dr;
        Constants c = Constants.GetConstants();
        string[] sarray;
        string info;

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
            this.cHARACTERSTableAdapter
                .FillWithExsHeroes(this.gameDbDataSet.CHARACTERS, loggedUser.Id);
            GameDbDataSet.CHARACTERSDataTable dtbl = this.cHARACTERSTableAdapter
                .GetData(loggedUser.Id);
            for(int k = 0; k < dtbl.Rows.Count; k++)
            {
                if(dtbl.ElementAt<GameDbDataSet.CHARACTERSRow>(k)
                .Field<int>(dtbl.HealthPointsColumn) > 0) { 
                    iDComboBox.Items.Add(dtbl.ElementAt<GameDbDataSet.CHARACTERSRow>(k)
                    .Field<int>(dtbl.IDColumn));
                    iDComboBox1.Items.Add(dtbl.ElementAt<GameDbDataSet.CHARACTERSRow>(k)
                    .Field<int>(dtbl.IDColumn));
                }
            }
            
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
            Character hero_1 = hs.GetHeroById((int)iDComboBox.SelectedItem);
            Character hero_2 = hs.GetHeroById((int)iDComboBox1.SelectedItem);
            Random r = new Random();
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
                    dr = MessageBox.Show(info);
                    timer1.Start();
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
                    dr = MessageBox.Show(info);
                    timer1.Start();
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

            Battle b = c.GetBattle();
            List<Round> rounds = c.GetLocalRounds();
            int count = rounds.Count;
            for(int j = 1; j <= count; j++)
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
                rounds.Remove(r2);
            }

            rs.Clear();
            MessageBox.Show("Готово!");
        }

        public DialogResult GetDialog()
        {
            return dr;
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            timer1.Stop();
            dr = GetDialog();
            dr = DialogResult.OK;
        }

    }
}
