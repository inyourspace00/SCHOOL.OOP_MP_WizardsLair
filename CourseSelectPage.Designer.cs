namespace OOP_MachineProblem_WizardsLair
{
    partial class CourseSelectPage
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
            this.lblCourseSelect = new System.Windows.Forms.Label();
            this.btnIT132 = new System.Windows.Forms.Button();
            this.btnHUM011 = new System.Windows.Forms.Button();
            this.btnENV075 = new System.Windows.Forms.Button();
            this.backButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseSelect
            // 
            this.lblCourseSelect.AutoSize = true;
            this.lblCourseSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseSelect.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourseSelect.Location = new System.Drawing.Point(172, 104);
            this.lblCourseSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseSelect.Name = "lblCourseSelect";
            this.lblCourseSelect.Size = new System.Drawing.Size(421, 63);
            this.lblCourseSelect.TabIndex = 2;
            this.lblCourseSelect.Text = "Choose Your Course";
            this.lblCourseSelect.UseCompatibleTextRendering = true;
            this.lblCourseSelect.Click += new System.EventHandler(this.lblCourseSelect_Click);
            // 
            // btnIT132
            // 
            this.btnIT132.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnIT132.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIT132.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIT132.Location = new System.Drawing.Point(283, 198);
            this.btnIT132.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIT132.Name = "btnIT132";
            this.btnIT132.Size = new System.Drawing.Size(187, 65);
            this.btnIT132.TabIndex = 3;
            this.btnIT132.Text = "IT132";
            this.btnIT132.UseVisualStyleBackColor = true;
            this.btnIT132.Click += new System.EventHandler(this.btnIT132_Click);
            // 
            // btnHUM011
            // 
            this.btnHUM011.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnHUM011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHUM011.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUM011.Location = new System.Drawing.Point(283, 276);
            this.btnHUM011.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHUM011.Name = "btnHUM011";
            this.btnHUM011.Size = new System.Drawing.Size(187, 65);
            this.btnHUM011.TabIndex = 4;
            this.btnHUM011.Text = "HUM011";
            this.btnHUM011.UseVisualStyleBackColor = true;
            this.btnHUM011.Click += new System.EventHandler(this.btnHUM011_Click);
            // 
            // btnENV075
            // 
            this.btnENV075.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnENV075.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENV075.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENV075.Location = new System.Drawing.Point(283, 356);
            this.btnENV075.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnENV075.Name = "btnENV075";
            this.btnENV075.Size = new System.Drawing.Size(187, 65);
            this.btnENV075.TabIndex = 5;
            this.btnENV075.Text = "ENV075";
            this.btnENV075.UseVisualStyleBackColor = true;
            this.btnENV075.Click += new System.EventHandler(this.btnENV075_Click);
            // 
            // backButton3
            // 
            this.backButton3.BackColor = System.Drawing.Color.Transparent;
            this.backButton3.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnBack;
            this.backButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton3.FlatAppearance.BorderSize = 0;
            this.backButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton3.Location = new System.Drawing.Point(9, 10);
            this.backButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backButton3.Name = "backButton3";
            this.backButton3.Size = new System.Drawing.Size(40, 43);
            this.backButton3.TabIndex = 10;
            this.backButton3.UseVisualStyleBackColor = false;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // CourseSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 586);
            this.Controls.Add(this.backButton3);
            this.Controls.Add(this.btnENV075);
            this.Controls.Add(this.btnHUM011);
            this.Controls.Add(this.btnIT132);
            this.Controls.Add(this.lblCourseSelect);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CourseSelectPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard\'s Lair!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseSelect;
        private System.Windows.Forms.Button btnIT132;
        private System.Windows.Forms.Button btnHUM011;
        private System.Windows.Forms.Button btnENV075;
        private System.Windows.Forms.Button backButton3;
    }
}