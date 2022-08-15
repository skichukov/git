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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // CreateHeroLink
            // 
            this.CreateHeroLink.AutoSize = true;
            this.CreateHeroLink.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
            this.CreateHeroLink.Location = new System.Drawing.Point(328, 161);
            this.CreateHeroLink.Name = "CreateHeroLink";
            this.CreateHeroLink.Size = new System.Drawing.Size(110, 13);
            this.CreateHeroLink.TabIndex = 0;
            this.CreateHeroLink.TabStop = true;
            this.CreateHeroLink.Text = "Създаване на герой";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(616, 97);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Изход";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.CreateHeroLink);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CreateHeroLink;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}