using Game.Models;
using Game.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class List_Heroes : Form
    {
        User loggedUser;
        HeroeService hs;
        Constants c = Constants.GetConstants(); 
        int id;

        public List_Heroes()
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
            // TODO: This line of code loads data into the 'gameDbDataSet.CHARACTERS' table. You can move, or remove it, as needed.
            this.cHARACTERSTableAdapter.Fill(this.gameDbDataSet.CHARACTERS, loggedUser.Id);
            this.cHARACTERSTableAdapter.Connection.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CreateHero ch = new CreateHero();
            ch.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(this.cHARACTERSDataGridView.CurrentCell.ColumnIndex == 0)
            {
                try {
                    id = (int) this.cHARACTERSDataGridView.CurrentCell.Value;
                    hs.DeleteHero(id);
                } catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void renHeroBtn_Click(object sender, EventArgs e)
        {     
            if (this.cHARACTERSDataGridView.CurrentCell.ColumnIndex == 0)
            {
                UpdateHero uh = new UpdateHero();
                uh.Show();
                id = (int)this.cHARACTERSDataGridView.CurrentCell.Value;
                uh.Print_Hero(id);
            }
            
        }
    }
}
