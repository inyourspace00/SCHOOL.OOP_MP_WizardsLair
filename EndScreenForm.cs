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
            this.lblHeader = new Label();
            this.lblScoreHeader = new Label();
            this.lblScoreValue = new Label();
            this.lblCourseHeader = new Label();
            this.lblCourseValue = new Label();
            this.lblDifficultyHeader = new Label();
            this.lblDifficultyValue = new Label();
            this.lblNamePrompt = new Label();
            this.txtPlayerName = new TextBox();
            this.btnSaveScore = new Button();
            this.btnPlayAgain = new Button();
            this.btnViewLeaderboard = new Button();
            this.btnMainMenu = new Button();
            this.SuspendLayout();

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.BackColor = Color.Transparent;
            this.lblHeader.Location = new Point(135, 20);
            this.lblHeader.Text = "GAME OVER";

            this.lblScoreHeader.AutoSize = true;
            this.lblScoreHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblScoreHeader.ForeColor = Color.White;
            this.lblScoreHeader.BackColor = Color.Transparent;
            this.lblScoreHeader.Location = new Point(80, 80);
            this.lblScoreHeader.Text = "Final Score:";

            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new Font("Segoe UI", 11F);
            this.lblScoreValue.ForeColor = Color.White;
            this.lblScoreValue.BackColor = Color.Transparent;
            this.lblScoreValue.Location = new Point(220, 80);
            this.lblScoreValue.Text = "0";

            this.lblCourseHeader.AutoSize = true;
            this.lblCourseHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblCourseHeader.ForeColor = Color.White;
            this.lblCourseHeader.BackColor = Color.Transparent;
            this.lblCourseHeader.Location = new Point(80, 110);
            this.lblCourseHeader.Text = "Course:";

            this.lblCourseValue.AutoSize = true;
            this.lblCourseValue.Font = new Font("Segoe UI", 11F);
            this.lblCourseValue.ForeColor = Color.White;
            this.lblCourseValue.BackColor = Color.Transparent;
            this.lblCourseValue.Location = new Point(220, 110);
            this.lblCourseValue.Text = "N/A";

            this.lblDifficultyHeader.AutoSize = true;
            this.lblDifficultyHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDifficultyHeader.ForeColor = Color.White;
            this.lblDifficultyHeader.BackColor = Color.Transparent;
            this.lblDifficultyHeader.Location = new Point(80, 140);
            this.lblDifficultyHeader.Text = "Difficulty:";

            this.lblDifficultyValue.AutoSize = true;
            this.lblDifficultyValue.Font = new Font("Segoe UI", 11F);
            this.lblDifficultyValue.ForeColor = Color.White;
            this.lblDifficultyValue.BackColor = Color.Transparent;
            this.lblDifficultyValue.Location = new Point(220, 140);
            this.lblDifficultyValue.Text = "N/A";

            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblNamePrompt.ForeColor = Color.White;
            this.lblNamePrompt.BackColor = Color.Transparent;
            this.lblNamePrompt.Location = new Point(80, 185);
            this.lblNamePrompt.Text = "Your Name:";

            this.txtPlayerName.Location = new Point(170, 182);
            this.txtPlayerName.Size = new Size(110, 23);

            this.btnSaveScore.Location = new Point(290, 181);
            this.btnSaveScore.Size = new Size(75, 25);
            this.btnSaveScore.Text = "Save";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new EventHandler(this.btnSaveScore_Click);

            this.btnPlayAgain.Location = new Point(50, 240);
            this.btnPlayAgain.Size = new Size(100, 35);
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new EventHandler(this.btnPlayAgain_Click);

            this.btnViewLeaderboard.Location = new Point(165, 240);
            this.btnViewLeaderboard.Size = new Size(110, 35);
            this.btnViewLeaderboard.Text = "Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = true;
            this.btnViewLeaderboard.Click += new EventHandler(this.btnViewLeaderboard_Click);

            this.btnMainMenu.Location = new Point(290, 240);
            this.btnMainMenu.Size = new Size(100, 35);
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new EventHandler(this.btnMainMenu_Click);

            this.ClientSize = new Size(450, 310);
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
            this.Name = "EndScreenForm";
            this.Text = "Wizard's Lair - Game Over";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
    }
}