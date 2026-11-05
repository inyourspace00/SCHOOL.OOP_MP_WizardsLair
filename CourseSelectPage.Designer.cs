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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseSelect
            // 
            this.lblCourseSelect.AutoSize = true;
            this.lblCourseSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourseSelect.Location = new System.Drawing.Point(204, 166);
            this.lblCourseSelect.Name = "lblCourseSelect";
            this.lblCourseSelect.Size = new System.Drawing.Size(715, 94);
            this.lblCourseSelect.TabIndex = 2;
            this.lblCourseSelect.Text = "Choose Your Course";
            this.lblCourseSelect.UseCompatibleTextRendering = true;
            this.lblCourseSelect.Click += new System.EventHandler(this.lblCourseSelect_Click);
            // 
            // btnIT132
            // 
            this.btnIT132.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnIT132.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIT132.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIT132.Location = new System.Drawing.Point(424, 305);
            this.btnIT132.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIT132.Name = "btnIT132";
            this.btnIT132.Size = new System.Drawing.Size(281, 100);
            this.btnIT132.TabIndex = 3;
            this.btnIT132.Text = "IT132";
            this.btnIT132.UseVisualStyleBackColor = true;
            this.btnIT132.Click += new System.EventHandler(this.btnIT132_Click);
            // 
            // btnHUM011
            // 
            this.btnHUM011.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnHUM011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHUM011.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUM011.Location = new System.Drawing.Point(424, 424);
            this.btnHUM011.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHUM011.Name = "btnHUM011";
            this.btnHUM011.Size = new System.Drawing.Size(281, 100);
            this.btnHUM011.TabIndex = 4;
            this.btnHUM011.Text = "HUM011";
            this.btnHUM011.UseVisualStyleBackColor = true;
            this.btnHUM011.Click += new System.EventHandler(this.btnHUM011_Click);
            // 
            // btnENV075
            // 
            this.btnENV075.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnENV075.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENV075.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENV075.Location = new System.Drawing.Point(424, 548);
            this.btnENV075.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnENV075.Name = "btnENV075";
            this.btnENV075.Size = new System.Drawing.Size(281, 100);
            this.btnENV075.TabIndex = 5;
            this.btnENV075.Text = "ENV075";
            this.btnENV075.UseVisualStyleBackColor = true;
            this.btnENV075.Click += new System.EventHandler(this.btnENV075_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnBack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 66);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 901);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnENV075);
            this.Controls.Add(this.btnHUM011);
            this.Controls.Add(this.btnIT132);
            this.Controls.Add(this.lblCourseSelect);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseSelectPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wizard\'s Lair!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseSelect;
        private System.Windows.Forms.Button btnIT132;
        private System.Windows.Forms.Button btnHUM011;
        private System.Windows.Forms.Button btnENV075;
        private System.Windows.Forms.Button button1;
    }
}