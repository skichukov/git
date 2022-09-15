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
            this.deleteTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CreateBattleLink = new System.Windows.Forms.LinkLabel();
            this.ViewBattlesLink = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateHeroLink
            // 
            this.CreateHeroLink.ActiveLinkColor = System.Drawing.Color.White;
            this.CreateHeroLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateHeroLink.AutoSize = true;
            this.CreateHeroLink.BackColor = System.Drawing.Color.Chocolate;
            this.CreateHeroLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateHeroLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateHeroLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.CreateHeroLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateHeroLink.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
            this.CreateHeroLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CreateHeroLink.LinkColor = System.Drawing.Color.White;
            this.CreateHeroLink.Location = new System.Drawing.Point(247, 102);
            this.CreateHeroLink.Name = "CreateHeroLink";
            this.CreateHeroLink.Size = new System.Drawing.Size(271, 33);
            this.CreateHeroLink.TabIndex = 0;
            this.CreateHeroLink.TabStop = true;
            this.CreateHeroLink.Text = "Създаване на герой";
            this.CreateHeroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateHeroLink_LinkClicked);
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
            this.lOutStripTextBox,
            this.deleteTextBox});
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
            // deleteTextBox
            // 
            this.deleteTextBox.AutoSize = false;
            this.deleteTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.ReadOnly = true;
            this.deleteTextBox.Size = new System.Drawing.Size(200, 23);
            this.deleteTextBox.Text = "Изтриване на профила";
            this.deleteTextBox.Click += new System.EventHandler(this.deleteTextBox_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Chocolate;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(265, 276);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(235, 33);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вижте героите си";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CreateBattleLink
            // 
            this.CreateBattleLink.ActiveLinkColor = System.Drawing.Color.White;
            this.CreateBattleLink.AutoSize = true;
            this.CreateBattleLink.BackColor = System.Drawing.Color.Chocolate;
            this.CreateBattleLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateBattleLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBattleLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateBattleLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CreateBattleLink.LinkColor = System.Drawing.Color.White;
            this.CreateBattleLink.Location = new System.Drawing.Point(246, 160);
            this.CreateBattleLink.Name = "CreateBattleLink";
            this.CreateBattleLink.Size = new System.Drawing.Size(272, 33);
            this.CreateBattleLink.TabIndex = 4;
            this.CreateBattleLink.TabStop = true;
            this.CreateBattleLink.Text = "Създаване на битка";
            this.CreateBattleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateBattleLink_LinkClicked);
            // 
            // ViewBattlesLink
            // 
            this.ViewBattlesLink.ActiveLinkColor = System.Drawing.Color.White;
            this.ViewBattlesLink.AutoSize = true;
            this.ViewBattlesLink.BackColor = System.Drawing.Color.Chocolate;
            this.ViewBattlesLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewBattlesLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBattlesLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewBattlesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ViewBattlesLink.LinkColor = System.Drawing.Color.White;
            this.ViewBattlesLink.Location = new System.Drawing.Point(237, 218);
            this.ViewBattlesLink.Name = "ViewBattlesLink";
            this.ViewBattlesLink.Size = new System.Drawing.Size(290, 33);
            this.ViewBattlesLink.TabIndex = 5;
            this.ViewBattlesLink.TabStop = true;
            this.ViewBattlesLink.Text = "Списък от битките Ви";
            this.ViewBattlesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewBattlesLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewBattlesLink);
            this.Controls.Add(this.CreateBattleLink);
            this.Controls.Add(this.linkLabel1);
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
        private System.Windows.Forms.ToolStripTextBox lOutStripTextBox;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ToolStripTextBox deleteTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel CreateBattleLink;
        private System.Windows.Forms.LinkLabel ViewBattlesLink;
    }
}