using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
    public partial class LeaderboardForm : Form
    {
        private string filePath = "leaderboard.txt";
        private ListBox lstScores;
        private Button btnClose;

        public LeaderboardForm()
        {
            InitializeComponent();
            LoadAndSortLeaderboard();

            this.BackgroundImage = Properties.Resources.MainBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InitializeComponent()
        {
            this.lstScores = new ListBox();
            this.btnClose = new Button();
            this.SuspendLayout();

            this.lstScores.FormattingEnabled = true;
            this.lstScores.Location = new System.Drawing.Point(30, 30);
            this.lstScores.Size = new System.Drawing.Size(390, 220);
            this.lstScores.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnClose.Location = new System.Drawing.Point(175, 270);
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.Text = "Close";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.btnClose);
            this.Name = "LeaderboardForm";
            this.Text = "Wizard's Lair - Leaderboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        private void LoadAndSortLeaderboard()
        {
            lstScores.Items.Clear();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .OrderByDescending(line => ExtractScore(line))
                    .ToList();

                if (lines.Count > 0)
                {
                    foreach (string line in lines)
                    {
                        lstScores.Items.Add(line);
                    }
                }
                else
                {
                    lstScores.Items.Add("No high scores recorded yet.");
                }
            }
            else
            {
                lstScores.Items.Add("No high scores recorded yet.");
            }
        }

        private int ExtractScore(string line)
        {
            try
            {
                string[] parts = line.Split('-');
                if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int score))
                {
                    return score;
                }
            }
            catch { }
            return 0;
        }

        public static void SaveScoreAuto(int score)
        {
            string userFile = "userData.txt";
            string playerName = "Guest";

            if (File.Exists(userFile))
            {
                string firstLine = File.ReadLines(userFile).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(firstLine))
                {
                    playerName = firstLine.Trim();
                }
            }

            string filePath = "leaderboard.txt";
            string entry = $"{playerName} - {score}";
            File.AppendAllText(filePath, entry + Environment.NewLine);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
