namespace OOP_MachineProblem_WizardsLair
{
    partial class QuizForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.picHealth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(45, 47);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "lblScore";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblQuestion.Location = new System.Drawing.Point(124, 183);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(756, 28);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "lblQuestion";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption1.ForeColor = System.Drawing.Color.Chocolate;
            this.rdoOption1.Location = new System.Drawing.Point(445, 315);
            this.rdoOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(94, 20);
            this.rdoOption1.TabIndex = 4;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.Text = "rdoOption1";
            this.rdoOption1.UseVisualStyleBackColor = false;
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption2.Location = new System.Drawing.Point(445, 354);
            this.rdoOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(94, 20);
            this.rdoOption2.TabIndex = 5;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.Text = "rdoOption2";
            this.rdoOption2.UseVisualStyleBackColor = false;
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption3.Location = new System.Drawing.Point(445, 399);
            this.rdoOption3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(94, 20);
            this.rdoOption3.TabIndex = 6;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.Text = "rdoOption3";
            this.rdoOption3.UseVisualStyleBackColor = false;
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption4.Location = new System.Drawing.Point(445, 441);
            this.rdoOption4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(94, 20);
            this.rdoOption4.TabIndex = 7;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.Text = "rdoOption4";
            this.rdoOption4.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.smallerButton;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(720, 508);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 50);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picHealth
            // 
            this.picHealth.BackColor = System.Drawing.Color.Transparent;
            this.picHealth.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.hp_3;
            this.picHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHealth.Location = new System.Drawing.Point(757, -10);
            this.picHealth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHealth.Name = "picHealth";
            this.picHealth.Size = new System.Drawing.Size(251, 171);
            this.picHealth.TabIndex = 10;
            this.picHealth.TabStop = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.picHealth);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdoOption4);
            this.Controls.Add(this.rdoOption3);
            this.Controls.Add(this.rdoOption2);
            this.Controls.Add(this.rdoOption1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard\'s Lair!";
            ((System.ComponentModel.ISupportInitialize)(this.picHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.RadioButton rdoOption4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picHealth;
    }
}