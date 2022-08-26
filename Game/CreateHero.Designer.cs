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
            this.lblClass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.createHeroBtn.Location = new System.Drawing.Point(165, 283);
            this.createHeroBtn.Name = "createHeroBtn";
            this.createHeroBtn.Size = new System.Drawing.Size(75, 23);
            this.createHeroBtn.TabIndex = 1;
            this.createHeroBtn.Text = "Създаване";
            this.createHeroBtn.UseVisualStyleBackColor = true;
            // 
            // lblNameHero
            // 
            this.lblNameHero.AutoSize = true;
            this.lblNameHero.Location = new System.Drawing.Point(80, 92);
            this.lblNameHero.Name = "lblNameHero";
            this.lblNameHero.Size = new System.Drawing.Size(29, 13);
            this.lblNameHero.TabIndex = 2;
            this.lblNameHero.Text = "Име";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(80, 135);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Клас";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // CreateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 364);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblClass);
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
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}