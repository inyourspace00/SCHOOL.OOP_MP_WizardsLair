using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
    // How to call this End Screen:
    // EndScreenForm endScreen = new EndScreenForm(finalScore, course, difficulty);
    // endScreen.Show();
    // this.Close();

    public partial class EndScreenForm : Form
    {
        private int finalScore;
        private string selectedCourse;
        private string difficultyLevel;

        private Label lblHeader;
        private Label lblScoreHeader;
        private Label lblScoreValue;
        private Label lblCourseHeader;
        private Label lblCourseValue;
        private Label lblDifficultyHeader;
        private Label lblDifficultyValue;
        private Label lblNamePrompt;
        private TextBox txtPlayerName;
        private Button btnSaveScore;
        private Button btnPlayAgain;
        private Button btnViewLeaderboard;
        private Button PaymentBtn;
        private Button btnMainMenu;

        public EndScreenForm(int score, string course, string difficulty)
        {
            InitializeComponent();
            finalScore = score;
            selectedCourse = course;
            difficultyLevel = difficulty;

            lblScoreValue.Text = finalScore.ToString();
            lblCourseValue.Text = selectedCourse;
            lblDifficultyValue.Text = difficultyLevel;

            this.BackgroundImage = Properties.Resources.MainBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblScoreHeader = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblCourseHeader = new System.Windows.Forms.Label();
            this.lblCourseValue = new System.Windows.Forms.Label();
            this.lblDifficultyHeader = new System.Windows.Forms.Label();
            this.lblDifficultyValue = new System.Windows.Forms.Label();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnViewLeaderboard = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(135, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(172, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "GAME OVER";
            // 
            // lblScoreHeader
            // 
            this.lblScoreHeader.AutoSize = true;
            this.lblScoreHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScoreHeader.ForeColor = System.Drawing.Color.White;
            this.lblScoreHeader.Location = new System.Drawing.Point(80, 80);
            this.lblScoreHeader.Name = "lblScoreHeader";
            this.lblScoreHeader.Size = new System.Drawing.Size(88, 20);
            this.lblScoreHeader.TabIndex = 1;
            this.lblScoreHeader.Text = "Final Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblScoreValue.ForeColor = System.Drawing.Color.White;
            this.lblScoreValue.Location = new System.Drawing.Point(220, 80);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(17, 20);
            this.lblScoreValue.TabIndex = 2;
            this.lblScoreValue.Text = "0";
            // 
            // lblCourseHeader
            // 
            this.lblCourseHeader.AutoSize = true;
            this.lblCourseHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCourseHeader.ForeColor = System.Drawing.Color.White;
            this.lblCourseHeader.Location = new System.Drawing.Point(80, 110);
            this.lblCourseHeader.Name = "lblCourseHeader";
            this.lblCourseHeader.Size = new System.Drawing.Size(61, 20);
            this.lblCourseHeader.TabIndex = 3;
            this.lblCourseHeader.Text = "Course:";
            // 
            // lblCourseValue
            // 
            this.lblCourseValue.AutoSize = true;
            this.lblCourseValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCourseValue.ForeColor = System.Drawing.Color.White;
            this.lblCourseValue.Location = new System.Drawing.Point(220, 110);
            this.lblCourseValue.Name = "lblCourseValue";
            this.lblCourseValue.Size = new System.Drawing.Size(36, 20);
            this.lblCourseValue.TabIndex = 4;
            this.lblCourseValue.Text = "N/A";
            // 
            // lblDifficultyHeader
            // 
            this.lblDifficultyHeader.AutoSize = true;
            this.lblDifficultyHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultyHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDifficultyHeader.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyHeader.Location = new System.Drawing.Point(80, 140);
            this.lblDifficultyHeader.Name = "lblDifficultyHeader";
            this.lblDifficultyHeader.Size = new System.Drawing.Size(78, 20);
            this.lblDifficultyHeader.TabIndex = 5;
            this.lblDifficultyHeader.Text = "Difficulty:";
            // 
            // lblDifficultyValue
            // 
            this.lblDifficultyValue.AutoSize = true;
            this.lblDifficultyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultyValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDifficultyValue.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyValue.Location = new System.Drawing.Point(220, 140);
            this.lblDifficultyValue.Name = "lblDifficultyValue";
            this.lblDifficultyValue.Size = new System.Drawing.Size(36, 20);
            this.lblDifficultyValue.TabIndex = 6;
            this.lblDifficultyValue.Text = "N/A";
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblNamePrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamePrompt.ForeColor = System.Drawing.Color.White;
            this.lblNamePrompt.Location = new System.Drawing.Point(80, 185);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(88, 19);
            this.lblNamePrompt.TabIndex = 7;
            this.lblNamePrompt.Text = "Your Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(170, 182);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(110, 20);
            this.txtPlayerName.TabIndex = 8;
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Location = new System.Drawing.Point(290, 181);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(75, 25);
            this.btnSaveScore.TabIndex = 9;
            this.btnSaveScore.Text = "Save";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(50, 240);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(100, 35);
            this.btnPlayAgain.TabIndex = 10;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnViewLeaderboard
            // 
            this.btnViewLeaderboard.Location = new System.Drawing.Point(165, 240);
            this.btnViewLeaderboard.Name = "btnViewLeaderboard";
            this.btnViewLeaderboard.Size = new System.Drawing.Size(110, 35);
            this.btnViewLeaderboard.TabIndex = 11;
            this.btnViewLeaderboard.Text = "Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = true;
            this.btnViewLeaderboard.Click += new System.EventHandler(this.btnViewLeaderboard_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(290, 240);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 35);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentBtn.Location = new System.Drawing.Point(338, 125);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(100, 35);
            this.PaymentBtn.TabIndex = 13;
            this.PaymentBtn.Text = "+1 Revive";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndScreenForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 310);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblScoreHeader);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblCourseHeader);
            this.Controls.Add(this.lblCourseValue);
            this.Controls.Add(this.lblDifficultyHeader);
            this.Controls.Add(this.lblDifficultyValue);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnViewLeaderboard);
            this.Controls.Add(this.btnMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EndScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard\'s Lair - Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Please enter your name first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //LeaderboardForm.SaveScore(playerName, finalScore);
            MessageBox.Show("Score saved to leaderboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSaveScore.Enabled = false;
            txtPlayerName.Enabled = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            CourseSelectPage courseSelect = new CourseSelectPage();
            courseSelect.Show();
            this.Close();
        }

        private void btnViewLeaderboard_Click(object sender, EventArgs e)
        {
            //LeaderboardForm leaderboard = new LeaderboardForm();
            //leaderboard.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}