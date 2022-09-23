namespace Game
{
    partial class Det_Battle
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
            System.Windows.Forms.Label character1StateLabel;
            System.Windows.Forms.Label character2StateLabel;
            System.Windows.Forms.Label roundIndexLabel;
            System.Windows.Forms.Label randomNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Det_Battle));
            this.gameDbDataSet = new Game.GameDbDataSet();
            this.rOUNDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOUNDSTableAdapter = new Game.GameDbDataSetTableAdapters.ROUNDSTableAdapter();
            this.tableAdapterManager = new Game.GameDbDataSetTableAdapters.TableAdapterManager();
            this.rOUNDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rOUNDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BtnBack = new System.Windows.Forms.ToolStripButton();
            this.character1StateTextBox = new System.Windows.Forms.TextBox();
            this.character2StateTextBox = new System.Windows.Forms.TextBox();
            this.roundIndexTextBox = new System.Windows.Forms.TextBox();
            this.randomNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            character1StateLabel = new System.Windows.Forms.Label();
            character2StateLabel = new System.Windows.Forms.Label();
            roundIndexLabel = new System.Windows.Forms.Label();
            randomNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUNDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUNDSBindingNavigator)).BeginInit();
            this.rOUNDSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // character1StateLabel
            // 
            character1StateLabel.AutoSize = true;
            character1StateLabel.Location = new System.Drawing.Point(206, 128);
            character1StateLabel.Name = "character1StateLabel";
            character1StateLabel.Size = new System.Drawing.Size(147, 13);
            character1StateLabel.TabIndex = 2;
            character1StateLabel.Text = "Кръв на атакуващия герой:";
            // 
            // character2StateLabel
            // 
            character2StateLabel.AutoSize = true;
            character2StateLabel.Location = new System.Drawing.Point(206, 154);
            character2StateLabel.Name = "character2StateLabel";
            character2StateLabel.Size = new System.Drawing.Size(172, 13);
            character2StateLabel.TabIndex = 4;
            character2StateLabel.Text = "Кръв на защитаващия се герой:";
            // 
            // roundIndexLabel
            // 
            roundIndexLabel.AutoSize = true;
            roundIndexLabel.Location = new System.Drawing.Point(206, 180);
            roundIndexLabel.Name = "roundIndexLabel";
            roundIndexLabel.Size = new System.Drawing.Size(67, 13);
            roundIndexLabel.TabIndex = 6;
            roundIndexLabel.Text = "Рунд поред:";
            // 
            // randomNumberLabel
            // 
            randomNumberLabel.AutoSize = true;
            randomNumberLabel.Location = new System.Drawing.Point(206, 206);
            randomNumberLabel.Name = "randomNumberLabel";
            randomNumberLabel.Size = new System.Drawing.Size(89, 13);
            randomNumberLabel.TabIndex = 8;
            randomNumberLabel.Text = "Случайно число:";
            // 
            // gameDbDataSet
            // 
            this.gameDbDataSet.DataSetName = "GameDbDataSet";
            this.gameDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOUNDSBindingSource
            // 
            this.rOUNDSBindingSource.DataMember = "ROUNDS";
            this.rOUNDSBindingSource.DataSource = this.gameDbDataSet;
            // 
            // rOUNDSTableAdapter
            // 
            this.rOUNDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BATTLESTableAdapter = null;
            this.tableAdapterManager.CHARACTERSTableAdapter = null;
            this.tableAdapterManager.ROUNDSTableAdapter = this.rOUNDSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Game.GameDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // rOUNDSBindingNavigator
            // 
            this.rOUNDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rOUNDSBindingNavigator.BindingSource = this.rOUNDSBindingSource;
            this.rOUNDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rOUNDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rOUNDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rOUNDSBindingNavigatorSaveItem,
            this.BtnBack});
            this.rOUNDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rOUNDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rOUNDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rOUNDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rOUNDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rOUNDSBindingNavigator.Name = "rOUNDSBindingNavigator";
            this.rOUNDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rOUNDSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.rOUNDSBindingNavigator.TabIndex = 0;
            this.rOUNDSBindingNavigator.Text = "bindingNavigator1";
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
            // rOUNDSBindingNavigatorSaveItem
            // 
            this.rOUNDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rOUNDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rOUNDSBindingNavigatorSaveItem.Image")));
            this.rOUNDSBindingNavigatorSaveItem.Name = "rOUNDSBindingNavigatorSaveItem";
            this.rOUNDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rOUNDSBindingNavigatorSaveItem.Text = "Save Data";
            this.rOUNDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.rOUNDSBindingNavigatorSaveItem_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(43, 22);
            this.BtnBack.Text = "Назад";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // character1StateTextBox
            // 
            this.character1StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOUNDSBindingSource, "Character1State", true));
            this.character1StateTextBox.Location = new System.Drawing.Point(384, 125);
            this.character1StateTextBox.Name = "character1StateTextBox";
            this.character1StateTextBox.ReadOnly = true;
            this.character1StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.character1StateTextBox.TabIndex = 3;
            // 
            // character2StateTextBox
            // 
            this.character2StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOUNDSBindingSource, "Character2State", true));
            this.character2StateTextBox.Location = new System.Drawing.Point(384, 151);
            this.character2StateTextBox.Name = "character2StateTextBox";
            this.character2StateTextBox.ReadOnly = true;
            this.character2StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.character2StateTextBox.TabIndex = 5;
            // 
            // roundIndexTextBox
            // 
            this.roundIndexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOUNDSBindingSource, "RoundIndex", true));
            this.roundIndexTextBox.Location = new System.Drawing.Point(384, 177);
            this.roundIndexTextBox.Name = "roundIndexTextBox";
            this.roundIndexTextBox.ReadOnly = true;
            this.roundIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.roundIndexTextBox.TabIndex = 7;
            // 
            // randomNumberTextBox
            // 
            this.randomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOUNDSBindingSource, "RandomNumber", true));
            this.randomNumberTextBox.Location = new System.Drawing.Point(384, 203);
            this.randomNumberTextBox.Name = "randomNumberTextBox";
            this.randomNumberTextBox.ReadOnly = true;
            this.randomNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.randomNumberTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Det_Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(character1StateLabel);
            this.Controls.Add(this.character1StateTextBox);
            this.Controls.Add(character2StateLabel);
            this.Controls.Add(this.character2StateTextBox);
            this.Controls.Add(roundIndexLabel);
            this.Controls.Add(this.roundIndexTextBox);
            this.Controls.Add(randomNumberLabel);
            this.Controls.Add(this.randomNumberTextBox);
            this.Controls.Add(this.rOUNDSBindingNavigator);
            this.Name = "Det_Battle";
            this.Text = "Det_Battle";
            this.Load += new System.EventHandler(this.Det_Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUNDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUNDSBindingNavigator)).EndInit();
            this.rOUNDSBindingNavigator.ResumeLayout(false);
            this.rOUNDSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameDbDataSet gameDbDataSet;
        private System.Windows.Forms.BindingSource rOUNDSBindingSource;
        private GameDbDataSetTableAdapters.ROUNDSTableAdapter rOUNDSTableAdapter;
        private GameDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rOUNDSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rOUNDSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox character1StateTextBox;
        private System.Windows.Forms.TextBox character2StateTextBox;
        private System.Windows.Forms.TextBox roundIndexTextBox;
        private System.Windows.Forms.TextBox randomNumberTextBox;
        private System.Windows.Forms.ToolStripButton BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}