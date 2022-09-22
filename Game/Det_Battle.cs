using Game.Models;
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
    public partial class Det_Battle : Form
    {
        Battle selectedBattle;
        Constants c = Constants.GetConstants();

        public Det_Battle()
        {
            InitializeComponent();
            selectedBattle = c.GetBattle();
        }

        private void rOUNDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOUNDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameDbDataSet);

        }

        private void Det_Battle_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.rOUNDSTableAdapter.Fill(this.gameDbDataSet.ROUNDS, selectedBattle.Id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List_Battles lb = new List_Battles();
            this.Hide();
            lb.Show();
        }
    }
}
