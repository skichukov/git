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
    public partial class List_Battles : Form
    {
        User loggedUser;
        Constants c = Constants.GetConstants();

        public List_Battles()
        {
            InitializeComponent();
            loggedUser = c.GetCurrentUser();
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

        }
    }
}
