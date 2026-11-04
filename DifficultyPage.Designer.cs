namespace OOP_MachineProblem_WizardsLair
{
    partial class DifficultyPage
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
            this.btnHard = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblDifficultySelect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHard
            // 
            this.btnHard.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHard.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(379, 350);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(250, 80);
            this.btnHard.TabIndex = 8;
            this.btnHard.Text = "HARD";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHUM011_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasy.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(379, 255);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(250, 80);
            this.btnEasy.TabIndex = 7;
            this.btnEasy.Text = "EASY";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnIT132_Click);
            // 
            // lblDifficultySelect
            // 
            this.lblDifficultySelect.AutoSize = true;
            this.lblDifficultySelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultySelect.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultySelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDifficultySelect.Location = new System.Drawing.Point(129, 135);
            this.lblDifficultySelect.Name = "lblDifficultySelect";
            this.lblDifficultySelect.Size = new System.Drawing.Size(830, 85);
            this.lblDifficultySelect.TabIndex = 6;
            this.lblDifficultySelect.Text = "Choose Your Difficulty";
            this.lblDifficultySelect.UseCompatibleTextRendering = true;
            this.lblDifficultySelect.Click += new System.EventHandler(this.lblCourseSelect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnBack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DifficultyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblDifficultySelect);
            this.DoubleBuffered = true;
            this.Name = "DifficultyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wizard\'s Lair!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblDifficultySelect;
        private System.Windows.Forms.Button button1;
    }
}