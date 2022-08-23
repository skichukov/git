namespace Game
{
    partial class MainForm
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
            this.CreateHeroLink = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.updateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lOutStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.listWithUsers = new System.Windows.Forms.ListBox();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateHeroLink
            // 
            this.CreateHeroLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateHeroLink.AutoSize = true;
            this.CreateHeroLink.BackColor = System.Drawing.Color.Chocolate;
            this.CreateHeroLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.CreateHeroLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateHeroLink.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
            this.CreateHeroLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CreateHeroLink.LinkColor = System.Drawing.Color.White;
            this.CreateHeroLink.Location = new System.Drawing.Point(256, 152);
            this.CreateHeroLink.Name = "CreateHeroLink";
            this.CreateHeroLink.Size = new System.Drawing.Size(269, 31);
            this.CreateHeroLink.TabIndex = 0;
            this.CreateHeroLink.TabStop = true;
            this.CreateHeroLink.Text = "Създаване на герой";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersTextBox,
            this.updateTextBox,
            this.lOutStripTextBox});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // viewUsersTextBox
            // 
            this.viewUsersTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewUsersTextBox.Name = "viewUsersTextBox";
            this.viewUsersTextBox.ReadOnly = true;
            this.viewUsersTextBox.Size = new System.Drawing.Size(200, 23);
            this.viewUsersTextBox.Text = "Вижте списъка с потребители";
            this.viewUsersTextBox.Click += new System.EventHandler(this.viewUsersTextBox_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.AutoSize = false;
            this.updateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.ReadOnly = true;
            this.updateTextBox.ShortcutsEnabled = false;
            this.updateTextBox.Size = new System.Drawing.Size(200, 23);
            this.updateTextBox.Text = "Редактирайте информацията си";
            this.updateTextBox.Click += new System.EventHandler(this.updtStripTextBox_Click);
            // 
            // lOutStripTextBox
            // 
            this.lOutStripTextBox.AutoSize = false;
            this.lOutStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lOutStripTextBox.Name = "lOutStripTextBox";
            this.lOutStripTextBox.ReadOnly = true;
            this.lOutStripTextBox.Size = new System.Drawing.Size(200, 23);
            this.lOutStripTextBox.Text = "Изход";
            this.lOutStripTextBox.Click += new System.EventHandler(this.lOutStripTextBox_Click);
            // 
            // listWithUsers
            // 
            this.listWithUsers.FormattingEnabled = true;
            this.listWithUsers.Location = new System.Drawing.Point(227, 226);
            this.listWithUsers.Name = "listWithUsers";
            this.listWithUsers.Size = new System.Drawing.Size(335, 134);
            this.listWithUsers.TabIndex = 3;
            this.listWithUsers.Visible = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listWithUsers);
            this.Controls.Add(this.CreateHeroLink);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CreateHeroLink;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox viewUsersTextBox;
        private System.Windows.Forms.ToolStripTextBox updateTextBox;
        private System.Windows.Forms.ListBox listWithUsers;
        private System.Windows.Forms.ToolStripTextBox lOutStripTextBox;
        private System.Data.DataSet dataSet1;
    }
}