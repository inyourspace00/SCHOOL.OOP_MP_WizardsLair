using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
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
        private Button btnPlayAgain;
        private Button btnViewLeaderboard;
        private Button PaymentBtn;

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

            AutoSaveScoreFromLogin();
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
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnViewLeaderboard = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(300, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(172, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "GAME OVER";

            this.lblScoreHeader.AutoSize = true;
            this.lblScoreHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScoreHeader.ForeColor = System.Drawing.Color.White;
            this.lblScoreHeader.Location = new System.Drawing.Point(240, 110);
            this.lblScoreHeader.Name = "lblScoreHeader";
            this.lblScoreHeader.Size = new System.Drawing.Size(88, 20);
            this.lblScoreHeader.TabIndex = 1;
            this.lblScoreHeader.Text = "Final Score:";

            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblScoreValue.ForeColor = System.Drawing.Color.White;
            this.lblScoreValue.Location = new System.Drawing.Point(400, 110);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(17, 20);
            this.lblScoreValue.TabIndex = 2;
            this.lblScoreValue.Text = "0";

            this.lblCourseHeader.AutoSize = true;
            this.lblCourseHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCourseHeader.ForeColor = System.Drawing.Color.White;
            this.lblCourseHeader.Location = new System.Drawing.Point(240, 150);
            this.lblCourseHeader.Name = "lblCourseHeader";
            this.lblCourseHeader.Size = new System.Drawing.Size(61, 20);
            this.lblCourseHeader.TabIndex = 3;
            this.lblCourseHeader.Text = "Course:";

            this.lblCourseValue.AutoSize = true;
            this.lblCourseValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCourseValue.ForeColor = System.Drawing.Color.White;
            this.lblCourseValue.Location = new System.Drawing.Point(400, 150);
            this.lblCourseValue.Name = "lblCourseValue";
            this.lblCourseValue.Size = new System.Drawing.Size(36, 20);
            this.lblCourseValue.TabIndex = 4;
            this.lblCourseValue.Text = "N/A";

            this.lblDifficultyHeader.AutoSize = true;
            this.lblDifficultyHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultyHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDifficultyHeader.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyHeader.Location = new System.Drawing.Point(240, 190);
            this.lblDifficultyHeader.Name = "lblDifficultyHeader";
            this.lblDifficultyHeader.Size = new System.Drawing.Size(78, 20);
            this.lblDifficultyHeader.TabIndex = 5;
            this.lblDifficultyHeader.Text = "Difficulty:";

            this.lblDifficultyValue.AutoSize = true;
            this.lblDifficultyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultyValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDifficultyValue.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyValue.Location = new System.Drawing.Point(400, 190);
            this.lblDifficultyValue.Name = "lblDifficultyValue";
            this.lblDifficultyValue.Size = new System.Drawing.Size(36, 20);
            this.lblDifficultyValue.TabIndex = 6;
            this.lblDifficultyValue.Text = "N/A";

            this.btnPlayAgain.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayAgain.Location = new System.Drawing.Point(100, 320);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(187, 65);
            this.btnPlayAgain.TabIndex = 7;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);

            this.btnViewLeaderboard.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.btnViewLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewLeaderboard.Location = new System.Drawing.Point(292, 320);
            this.btnViewLeaderboard.Name = "btnViewLeaderboard";
            this.btnViewLeaderboard.Size = new System.Drawing.Size(187, 65);
            this.btnViewLeaderboard.TabIndex = 8;
            this.btnViewLeaderboard.Text = "Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = true;
            this.btnViewLeaderboard.Click += new System.EventHandler(this.btnViewLeaderboard_Click);

            this.PaymentBtn.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.btnStart;
            this.PaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentBtn.Location = new System.Drawing.Point(484, 320);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(187, 65);
            this.PaymentBtn.TabIndex = 9;
            this.PaymentBtn.Text = "+1 Revive";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);

            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 625);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblScoreHeader);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblCourseHeader);
            this.Controls.Add(this.lblCourseValue);
            this.Controls.Add(this.lblDifficultyHeader);
            this.Controls.Add(this.lblDifficultyValue);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnViewLeaderboard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EndScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard's Lair - Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AutoSaveScoreFromLogin()
        {
            string playerName = "Guest";
            string userFile = "userData.txt";

            if (File.Exists(userFile))
            {
                string firstLine = File.ReadLines(userFile).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(firstLine))
                {
                    // Split by common delimiters like colon, comma, or dash if passwords are stored on the same line
                    char[] delimiters = { ':', ',', '-' };
                    string extractedName = firstLine.Split(delimiters)[0].Trim();

                    if (!string.IsNullOrEmpty(extractedName))
                    {
                        playerName = extractedName;
                    }
                }
            }

            string scoreEntry = $"{playerName} - {finalScore}";

            try
            {
                File.AppendAllText("leaderboard.txt", scoreEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            CourseSelectPage courseSelect = new CourseSelectPage();
            courseSelect.Show();
            this.Close();
        }

        private void btnViewLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboard = new LeaderboardForm();
            leaderboard.ShowDialog();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to payment gateway for +1 Revive...", "Revive Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}