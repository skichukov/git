namespace Game
{
    partial class CreateHero
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
            this.label1 = new System.Windows.Forms.Label();
            this.createHeroBtn = new System.Windows.Forms.Button();
            this.lblNameHero = new System.Windows.Forms.Label();
            this.textBox_heroName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Създаване на герой";
            // 
            // createHeroBtn
            // 
            this.createHeroBtn.Location = new System.Drawing.Point(153, 198);
            this.createHeroBtn.Name = "createHeroBtn";
            this.createHeroBtn.Size = new System.Drawing.Size(75, 23);
            this.createHeroBtn.TabIndex = 1;
            this.createHeroBtn.Text = "Създаване";
            this.createHeroBtn.UseVisualStyleBackColor = true;
            this.createHeroBtn.Click += new System.EventHandler(this.createHeroBtn_Click);
            // 
            // lblNameHero
            // 
            this.lblNameHero.AutoSize = true;
            this.lblNameHero.Location = new System.Drawing.Point(87, 114);
            this.lblNameHero.Name = "lblNameHero";
            this.lblNameHero.Size = new System.Drawing.Size(76, 13);
            this.lblNameHero.TabIndex = 2;
            this.lblNameHero.Text = "Име на героя";
            // 
            // textBox_heroName
            // 
            this.textBox_heroName.Location = new System.Drawing.Point(196, 111);
            this.textBox_heroName.Name = "textBox_heroName";
            this.textBox_heroName.Size = new System.Drawing.Size(100, 20);
            this.textBox_heroName.TabIndex = 4;
            // 
            // CreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 251);
            this.Controls.Add(this.textBox_heroName);
            this.Controls.Add(this.lblNameHero);
            this.Controls.Add(this.createHeroBtn);
            this.Controls.Add(this.label1);
            this.Name = "CreateHero";
            this.Text = "CreateHero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createHeroBtn;
        private System.Windows.Forms.Label lblNameHero;
        private System.Windows.Forms.TextBox textBox_heroName;
    }
}