namespace Game
{
    partial class CreateBattle
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBattle));
            this.btnCreate = new System.Windows.Forms.Button();
            this.gameDbDataSet = new Game.GameDbDataSet();
            this.cHARACTERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHARACTERSTableAdapter = new Game.GameDbDataSetTableAdapters.CHARACTERSTableAdapter();
            this.tableAdapterManager = new Game.GameDbDataSetTableAdapters.TableAdapterManager();
            this.cHARACTERSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cHARACTERSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BtnBack = new System.Windows.Forms.ToolStripButton();
            this.cHARACTERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDComboBox = new System.Windows.Forms.ComboBox();
            this.iDComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSBindingNavigator)).BeginInit();
            this.cHARACTERSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(49, 246);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(258, 246);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 5;
            iDLabel1.Text = "ID:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(188, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Създай";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gameDbDataSet
            // 
            this.gameDbDataSet.DataSetName = "GameDbDataSet";
            this.gameDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHARACTERSBindingSource
            // 
            this.cHARACTERSBindingSource.DataMember = "CHARACTERS";
            this.cHARACTERSBindingSource.DataSource = this.gameDbDataSet;
            // 
            // cHARACTERSTableAdapter
            // 
            this.cHARACTERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BATTLESTableAdapter = null;
            this.tableAdapterManager.CHARACTERSTableAdapter = this.cHARACTERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Game.GameDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // cHARACTERSBindingNavigator
            // 
            this.cHARACTERSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cHARACTERSBindingNavigator.BindingSource = this.cHARACTERSBindingSource;
            this.cHARACTERSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cHARACTERSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cHARACTERSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cHARACTERSBindingNavigatorSaveItem,
            this.BtnBack});
            this.cHARACTERSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cHARACTERSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cHARACTERSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cHARACTERSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cHARACTERSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cHARACTERSBindingNavigator.Name = "cHARACTERSBindingNavigator";
            this.cHARACTERSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cHARACTERSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cHARACTERSBindingNavigator.TabIndex = 1;
            this.cHARACTERSBindingNavigator.Text = "bindingNavigator1";
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
            // cHARACTERSBindingNavigatorSaveItem
            // 
            this.cHARACTERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cHARACTERSBindingNavigatorSaveItem.Enabled = false;
            this.cHARACTERSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cHARACTERSBindingNavigatorSaveItem.Image")));
            this.cHARACTERSBindingNavigatorSaveItem.Name = "cHARACTERSBindingNavigatorSaveItem";
            this.cHARACTERSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cHARACTERSBindingNavigatorSaveItem.Text = "Save Data";
            this.cHARACTERSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cHARACTERSBindingNavigatorSaveItem_Click);
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
            // cHARACTERSDataGridView
            // 
            this.cHARACTERSDataGridView.AutoGenerateColumns = false;
            this.cHARACTERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cHARACTERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cHARACTERSDataGridView.DataSource = this.cHARACTERSBindingSource;
            this.cHARACTERSDataGridView.Location = new System.Drawing.Point(489, 107);
            this.cHARACTERSDataGridView.Name = "cHARACTERSDataGridView";
            this.cHARACTERSDataGridView.Size = new System.Drawing.Size(244, 220);
            this.cHARACTERSDataGridView.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CharacterName";
            this.dataGridViewTextBoxColumn3.HeaderText = "CharacterName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AttackPoints";
            this.dataGridViewTextBoxColumn4.HeaderText = "AttackPoints";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DefencePoints";
            this.dataGridViewTextBoxColumn5.HeaderText = "DefencePoints";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HealthPoints";
            this.dataGridViewTextBoxColumn6.HeaderText = "HealthPoints";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateCreated";
            this.dataGridViewTextBoxColumn7.HeaderText = "DateCreated";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // iDComboBox
            // 
            this.iDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHARACTERSBindingSource, "ID", true));
            this.iDComboBox.FormattingEnabled = true;
            this.iDComboBox.Location = new System.Drawing.Point(76, 243);
            this.iDComboBox.Name = "iDComboBox";
            this.iDComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDComboBox.TabIndex = 4;
            // 
            // iDComboBox1
            // 
            this.iDComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHARACTERSBindingSource, "ID", true));
            this.iDComboBox1.FormattingEnabled = true;
            this.iDComboBox1.Location = new System.Drawing.Point(285, 243);
            this.iDComboBox1.Name = "iDComboBox1";
            this.iDComboBox1.Size = new System.Drawing.Size(121, 21);
            this.iDComboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Опонент 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(290, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Опонент 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(257, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Създаване на битка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(61, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Избери 2 опонента измежду героите:";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // CreateBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDComboBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDComboBox);
            this.Controls.Add(this.cHARACTERSDataGridView);
            this.Controls.Add(this.cHARACTERSBindingNavigator);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateBattle";
            this.Text = "CreateBattle";
            this.Load += new System.EventHandler(this.List_Heroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSBindingNavigator)).EndInit();
            this.cHARACTERSBindingNavigator.ResumeLayout(false);
            this.cHARACTERSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private GameDbDataSet gameDbDataSet;
        private System.Windows.Forms.BindingSource cHARACTERSBindingSource;
        private GameDbDataSetTableAdapters.CHARACTERSTableAdapter cHARACTERSTableAdapter;
        private GameDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cHARACTERSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cHARACTERSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cHARACTERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox iDComboBox;
        private System.Windows.Forms.ComboBox iDComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton BtnBack;
        private System.Windows.Forms.Timer timer1;
    }
}