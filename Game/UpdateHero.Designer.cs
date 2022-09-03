namespace Game
{
    partial class UpdateHero
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
            this.heroName = new System.Windows.Forms.Label();
            this.heroNameBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.attackpUpDown = new System.Windows.Forms.NumericUpDown();
            this.defpUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthpUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attackpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthpUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактиране на герой";
            // 
            // heroName
            // 
            this.heroName.AutoSize = true;
            this.heroName.Location = new System.Drawing.Point(81, 127);
            this.heroName.Name = "heroName";
            this.heroName.Size = new System.Drawing.Size(29, 13);
            this.heroName.TabIndex = 1;
            this.heroName.Text = "Име";
            // 
            // heroNameBox
            // 
            this.heroNameBox.Location = new System.Drawing.Point(192, 124);
            this.heroNameBox.Name = "heroNameBox";
            this.heroNameBox.Size = new System.Drawing.Size(120, 20);
            this.heroNameBox.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // attackpUpDown
            // 
            this.attackpUpDown.Location = new System.Drawing.Point(192, 164);
            this.attackpUpDown.Name = "attackpUpDown";
            this.attackpUpDown.Size = new System.Drawing.Size(120, 20);
            this.attackpUpDown.TabIndex = 4;
            // 
            // defpUpDown
            // 
            this.defpUpDown.Location = new System.Drawing.Point(192, 204);
            this.defpUpDown.Name = "defpUpDown";
            this.defpUpDown.Size = new System.Drawing.Size(120, 20);
            this.defpUpDown.TabIndex = 5;
            // 
            // healthpUpDown
            // 
            this.healthpUpDown.Location = new System.Drawing.Point(192, 242);
            this.healthpUpDown.Name = "healthpUpDown";
            this.healthpUpDown.Size = new System.Drawing.Size(120, 20);
            this.healthpUpDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кръв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Точки за защита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Точки за атака";
            // 
            // UpdateHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthpUpDown);
            this.Controls.Add(this.defpUpDown);
            this.Controls.Add(this.attackpUpDown);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.heroNameBox);
            this.Controls.Add(this.heroName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateHero";
            this.Text = "UpdateHero";
            ((System.ComponentModel.ISupportInitialize)(this.attackpUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defpUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthpUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.TextBox heroNameBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown attackpUpDown;
        private System.Windows.Forms.NumericUpDown defpUpDown;
        private System.Windows.Forms.NumericUpDown healthpUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}