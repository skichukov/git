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
    public partial class List_Battles : Form
    {
        User loggedUser;
        BattleService bs;
        HeroeService hs;
        Constants c = Constants.GetConstants();
        int id;
        string[] strings;
        string battle_info;

        public List_Battles()
        {
            InitializeComponent();
            loggedUser = c.GetCurrentUser();
            bs = c.GetBattleService();
            hs = c.GetHeroeService();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(SetCloseOperation);
        }

        private void SetCloseOperation(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bATTLESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bATTLESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameDbDataSet);

        }

        private void List_Battles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameDbDataSet.BATTLES' table. You can move, or remove it, as needed.
            this.bATTLESTableAdapter.Fill(this.gameDbDataSet.BATTLES, loggedUser.Id);
            this.bATTLESTableAdapter.Connection.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void lessDetailsTextBox_Click(object sender, EventArgs e)
        {
            if(this.bATTLESDataGridView.CurrentCell.ColumnIndex == 0)
            {
                id = (int) this.bATTLESDataGridView.CurrentCell.Value;
                Battle b = bs.GetBattleById(id);
                Character w = hs.GetHeroById(b.WinnerId);
                Character l = hs.GetHeroById(b.LoserId);
                strings = new string[]
                {
                    "Играли са: " + w.CharacterName + " и " + l.CharacterName,
                    "Победител е: " + w.CharacterName
                };

                battle_info = String.Join("\n", strings);
                MessageBox.Show(battle_info);
            }
            else
            {
                MessageBox.Show("Избери битка по Id!");
            }
        }

        private void moreDetailsTextBox_Click(object sender, EventArgs e)
        {
            if (this.bATTLESDataGridView.CurrentCell.ColumnIndex == 0)
            {
                id = (int)this.bATTLESDataGridView.CurrentCell.Value;
                Battle b = bs.GetBattleById(id);
                Det_Battle details = new Det_Battle();
                this.Hide();
                details.Show();
            }
            else
            {
                MessageBox.Show("Избери битка по Id!");
            }
        }
    }
}
