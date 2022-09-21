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

        public Det_Battle()
        {
            InitializeComponent();
        }

        private void rOUNDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOUNDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameDbDataSet);

        }

        private void fill(Battle b)
        {
            try
            {
                this.rOUNDSTableAdapter.Fill(this.gameDbDataSet.ROUNDS, b.Id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
