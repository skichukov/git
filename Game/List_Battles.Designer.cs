namespace Game
{
    partial class List_Battles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Battles));
            this.gameDbDataSet = new Game.GameDbDataSet();
            this.bATTLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bATTLESTableAdapter = new Game.GameDbDataSetTableAdapters.BATTLESTableAdapter();
            this.tableAdapterManager = new Game.GameDbDataSetTableAdapters.TableAdapterManager();
            this.bATTLESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bATTLESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bATTLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBack = new System.Windows.Forms.ToolStripButton();
            this.seeDetails_Btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.lessDetailsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.moreDetailsTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESBindingNavigator)).BeginInit();
            this.bATTLESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDbDataSet
            // 
            this.gameDbDataSet.DataSetName = "GameDbDataSet";
            this.gameDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bATTLESBindingSource
            // 
            this.bATTLESBindingSource.DataMember = "BATTLES";
            this.bATTLESBindingSource.DataSource = this.gameDbDataSet;
            // 
            // bATTLESTableAdapter
            // 
            this.bATTLESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BATTLESTableAdapter = this.bATTLESTableAdapter;
            this.tableAdapterManager.CHARACTERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Game.GameDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // bATTLESBindingNavigator
            // 
            this.bATTLESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bATTLESBindingNavigator.BindingSource = this.bATTLESBindingSource;
            this.bATTLESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bATTLESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bATTLESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bATTLESBindingNavigatorSaveItem,
            this.BtnBack,
            this.seeDetails_Btn});
            this.bATTLESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bATTLESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bATTLESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bATTLESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bATTLESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bATTLESBindingNavigator.Name = "bATTLESBindingNavigator";
            this.bATTLESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bATTLESBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bATTLESBindingNavigator.TabIndex = 0;
            this.bATTLESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bATTLESBindingNavigatorSaveItem
            // 
            this.bATTLESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bATTLESBindingNavigatorSaveItem.Enabled = false;
            this.bATTLESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bATTLESBindingNavigatorSaveItem.Image")));
            this.bATTLESBindingNavigatorSaveItem.Name = "bATTLESBindingNavigatorSaveItem";
            this.bATTLESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bATTLESBindingNavigatorSaveItem.Text = "Save Data";
            this.bATTLESBindingNavigatorSaveItem.Click += new System.EventHandler(this.bATTLESBindingNavigatorSaveItem_Click);
            // 
            // bATTLESDataGridView
            // 
            this.bATTLESDataGridView.AutoGenerateColumns = false;
            this.bATTLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bATTLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bATTLESDataGridView.DataSource = this.bATTLESBindingSource;
            this.bATTLESDataGridView.Location = new System.Drawing.Point(247, 83);
            this.bATTLESDataGridView.Name = "bATTLESDataGridView";
            this.bATTLESDataGridView.Size = new System.Drawing.Size(243, 220);
            this.bATTLESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WinnerId";
            this.dataGridViewTextBoxColumn3.HeaderText = "WinnerId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoserId";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoserId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // BtnBack
            // 
            this.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(23, 22);
            this.BtnBack.Text = "Към началния екран";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // seeDetails_Btn
            // 
            this.seeDetails_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.seeDetails_Btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessDetailsTextBox,
            this.moreDetailsTextBox});
            this.seeDetails_Btn.Image = ((System.Drawing.Image)(resources.GetObject("seeDetails_Btn.Image")));
            this.seeDetails_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.seeDetails_Btn.Name = "seeDetails_Btn";
            this.seeDetails_Btn.Size = new System.Drawing.Size(119, 22);
            this.seeDetails_Btn.Text = "Виж подробности";
            // 
            // lessDetailsTextBox
            // 
            this.lessDetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lessDetailsTextBox.Name = "lessDetailsTextBox";
            this.lessDetailsTextBox.ReadOnly = true;
            this.lessDetailsTextBox.Size = new System.Drawing.Size(125, 23);
            this.lessDetailsTextBox.Text = "В кратка форма";
            this.lessDetailsTextBox.Click += new System.EventHandler(this.lessDetailsTextBox_Click);
            // 
            // moreDetailsTextBox
            // 
            this.moreDetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.moreDetailsTextBox.Name = "moreDetailsTextBox";
            this.moreDetailsTextBox.ReadOnly = true;
            this.moreDetailsTextBox.Size = new System.Drawing.Size(125, 23);
            this.moreDetailsTextBox.Text = "Повече подробности";
            // 
            // List_Battles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bATTLESDataGridView);
            this.Controls.Add(this.bATTLESBindingNavigator);
            this.Name = "List_Battles";
            this.Text = "List_Battles";
            this.Load += new System.EventHandler(this.List_Battles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESBindingNavigator)).EndInit();
            this.bATTLESBindingNavigator.ResumeLayout(false);
            this.bATTLESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bATTLESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameDbDataSet gameDbDataSet;
        private System.Windows.Forms.BindingSource bATTLESBindingSource;
        private GameDbDataSetTableAdapters.BATTLESTableAdapter bATTLESTableAdapter;
        private GameDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bATTLESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bATTLESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bATTLESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton BtnBack;
        private System.Windows.Forms.ToolStripDropDownButton seeDetails_Btn;
        private System.Windows.Forms.ToolStripTextBox lessDetailsTextBox;
        private System.Windows.Forms.ToolStripTextBox moreDetailsTextBox;
    }
}