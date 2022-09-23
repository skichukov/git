﻿using Game.Models;
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
        string info_WandL;
        string[] arr;
        int dif;
        Constants c = Constants.GetConstants();

        public Det_Battle()
        { 
            selectedBattle = c.GetBattle();
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(SetCloseOperation);
        }

        private void SetCloseOperation(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
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
                GameDbDataSet.ROUNDSDataTable dtbl = this.rOUNDSTableAdapter
                    .GetData(selectedBattle.Id);
                if(dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(dtbl.Rows.Count - 1)
                    .Field<int>(dtbl.Character1StateColumn) > 0)
                {
                    info_WandL = "Победител е атакуващият герой.";
                }
                else
                {
                    info_WandL = "Победител е защитаващият се герой.";
                }
                /*
                if(dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(0)
                    .Field<int>(dtbl.Character1StateColumn) == 50)
                {
                    dif = 50 - (dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(0)
                        .Field<int>(dtbl.Character2StateColumn));
                    arr[0] = "Атакуващият герой е нанесъл " + dif + " удара на защитаващия се.";

                }
                else
                {
                    dif = 50 - (dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(0)
                        .Field<int>(dtbl.Character1StateColumn));
                    arr[0] = "Защитаващият се герой е нанесъл " + dif + " удара на атакуващия.";
                }
                
                for (int k = 1; k < dtbl.Rows.Count; k++)
                {
                    if (dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k - 1)
                        .Field<int>(dtbl.Character1StateColumn) >
                       dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k)
                        .Field<int>(dtbl.Character1StateColumn))
                    {
                        dif = dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k - 1)
                        .Field<int>(dtbl.Character1StateColumn) -
                       dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k)
                        .Field<int>(dtbl.Character1StateColumn);
                        arr[k] = "Защитаващият се герой е нанесъл " + dif + " удара на атакуващия.";
                    }
                    else
                    {
                        dif = dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k - 1)
                        .Field<int>(dtbl.Character2StateColumn) -
                       dtbl.ElementAt<GameDbDataSet.ROUNDSRow>(k)
                        .Field<int>(dtbl.Character2StateColumn);
                        arr[k] = "Атакуващият герой е нанесъл " + dif + " удара на защитаващия се.";
                    }
                }
                */
                for (int n = 1; n <= dtbl.Rows.Count; n++)
                {
                    if (roundIndexTextBox.Text == n.ToString())
                    {
                        label1.Text = info_WandL;
                    }                                                 
                }
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                this.rOUNDSTableAdapter.Connection.Close();
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            List_Battles lb = new List_Battles();
            this.Hide();
            lb.Show();
        }
    }
}
