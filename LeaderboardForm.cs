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
        private Label lblHeader;
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
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.BackColor = System.Drawing.Color.Wheat;
            this.lstScores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 17;
            this.lstScores.Location = new System.Drawing.Point(175, 64);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(100, 174);
            this.lstScores.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.smallerButton;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(175, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(139, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(181, 37);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Leaderboard";
            // 
            // LeaderboardForm
            // 
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LeaderboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard\'s Lair - Leaderboard";
            this.ResumeLayout(false);
            this.PerformLayout();

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