using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
    public partial class QuizForm : Form
    {
        public class Question
        {
            public string Text { get; set; }
            public string Option1 { get; set; }
            public string Option2 { get; set; }
            public string Option3 { get; set; }
            public string Option4 { get; set; }
            public int CorrectOptionIndex { get; set; }
        }

        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;
        private int health = 3;
        private Random rand = new Random();

        public string SelectedCourse { get; set; }
        public string SelectedDifficulty { get; set; }

        public QuizForm(string course = "IT132", string difficulty = "EASY")
        {
            InitializeComponent();
            ApplyRetroTheme();
            this.SelectedCourse = course;
            this.SelectedDifficulty = difficulty;

            LoadQuestionsFromFile();
            DisplayQuestion();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadQuestionsFromFile()
        {
            questions.Clear();
            string rawData = string.Empty;
            string fileName = $"{SelectedCourse}.txt";

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] searchPaths = {
                Path.Combine(baseDir, fileName),
                Path.Combine(baseDir, "Resources", fileName),
                Path.Combine(baseDir, "..", "..", "..", "Resources", fileName),
                Path.Combine(baseDir, "..", "..", "Resources", fileName),
                Path.Combine(Directory.GetCurrentDirectory(), fileName),
                Path.Combine(Directory.GetCurrentDirectory(), "Resources", fileName)
            };

            foreach (string path in searchPaths)
            {
                if (File.Exists(path))
                {
                    rawData = File.ReadAllText(path);
                    break;
                }
            }

            if (!string.IsNullOrEmpty(rawData))
            {
                string[] lines = rawData.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i += 5)
                {
                    if (i + 4 < lines.Length)
                    {
                        string qText = lines[i].Trim();
                        string[] opts = new string[4];
                        opts[0] = lines[i + 1].Trim();
                        opts[1] = lines[i + 2].Trim();
                        opts[2] = lines[i + 3].Trim();
                        opts[3] = lines[i + 4].Trim();

                        int correctIndex = 1;

                        for (int j = 0; j < 4; j++)
                        {
                            if (opts[j].StartsWith(">"))
                            {
                                correctIndex = j + 1;
                                opts[j] = opts[j].Substring(1).Trim();
                                break;
                            }
                        }

                        var optionList = new List<(string Text, bool IsCorrect)>();
                        for (int j = 0; j < 4; j++)
                        {
                            optionList.Add((opts[j], j + 1 == correctIndex));
                        }

                        int n = optionList.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = rand.Next(n + 1);
                            var value = optionList[k];
                            optionList[k] = optionList[n];
                            optionList[n] = value;
                        }

                        int newCorrectIndex = 1;
                        for (int j = 0; j < 4; j++)
                        {
                            opts[j] = optionList[j].Text;
                            if (optionList[j].IsCorrect)
                            {
                                newCorrectIndex = j + 1;
                            }
                        }

                        questions.Add(new Question
                        {
                            Text = qText,
                            Option1 = opts[0],
                            Option2 = opts[1],
                            Option3 = opts[2],
                            Option4 = opts[3],
                            CorrectOptionIndex = newCorrectIndex
                        });
                    }
                }
            }

            if (questions.Count == 0)
            {
                questions.Add(new Question
                {
                    Text = $"[Test Question for {SelectedCourse}] What is the correct option?",
                    Option1 = "Wrong Option 1",
                    Option2 = "Correct Option (This is right)",
                    Option3 = "Wrong Option 3",
                    Option4 = "Wrong Option 4",
                    CorrectOptionIndex = 2
                });
                questions.Add(new Question
                {
                    Text = $"[Test Question 2 for {SelectedCourse}] Select the valid choice:",
                    Option2 = "Wrong Option",
                    Option1 = "Correct Choice",
                    Option3 = "Wrong Option",
                    Option4 = "Wrong Option",
                    CorrectOptionIndex = 1
                });
            }
        }

        private string NamesDebugInfo(string course)
        {
            return $"Could not find '{course}.txt' in any directory!\n\n" +
                   $"Current Directory: {Environment.CurrentDirectory}\n" +
                   $"Make sure your .txt files are placed in the 'Resources' folder and set to 'Copy if newer'.";
        }

        private void DisplayQuestion()
        {
            if (questions.Count == 0 || currentQuestionIndex >= questions.Count)
            {
                EndQuiz();
                return;
            }

            Question q = questions[currentQuestionIndex];
            lblQuestion.Text = q.Text;
            rdoOption1.Text = q.Option1;
            rdoOption2.Text = q.Option2;
            rdoOption3.Text = q.Option3;
            rdoOption4.Text = q.Option4;

            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;

            lblScore.Text = $"Score: {score}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            if (rdoOption1.Checked) selectedIndex = 1;
            else if (rdoOption2.Checked) selectedIndex = 2;
            else if (rdoOption3.Checked) selectedIndex = 3;
            else if (rdoOption4.Checked) selectedIndex = 4;

            if (selectedIndex == 0)
            {
                MessageBox.Show("Please select an answer first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Question currentQ = questions[currentQuestionIndex];
            if (selectedIndex == currentQ.CorrectOptionIndex)
            {
                score++;
            }
            else
            {
                health--;
                UpdateHealthUI();
            }

            currentQuestionIndex++;

            if (health <= 0)
            {
                using (MiniGame miniGame = new MiniGame())
                {
                    miniGame.ShowDialog(this);

                    if (miniGame.Won)
                    {
                        health = 1;
                        UpdateHealthUI();
                        DisplayQuestion();
                    }
                    else
                    {
                        MessageBox.Show("Game Over! You ran out of health.", "Wizards Lair", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        EndQuiz();
                    }
                }
            }
            else
            {
                DisplayQuestion();
            }
        }

        private void UpdateHealthUI()
        {
            if (health == 3)
            {
                picHealth.BackgroundImage = Properties.Resources.hp_3;
            }
            else if (health == 2)
            {
                picHealth.BackgroundImage = Properties.Resources.hp_2;
            }
            else if (health == 1)
            {
                picHealth.BackgroundImage = Properties.Resources.hp_1;
            }
            else
            {
                picHealth.Image = null;
            }
        }

        private void EndQuiz()
        {
            EndScreenForm endScreen = new EndScreenForm(score, SelectedCourse, SelectedDifficulty);
            endScreen.Show();
            this.Close();
        }

        private void picBackground_Click(object sender, EventArgs e)
        {
        }

        private void ApplyRetroTheme()
        {
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.Gold;
            lblScore.Font = new Font("Consolas", 11, FontStyle.Bold);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.BorderStyle = BorderStyle.None;

            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Font = new Font("Consolas", 12, FontStyle.Bold);
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.BorderStyle = BorderStyle.None;
            lblQuestion.AutoSize = true;
            lblQuestion.MaximumSize = new System.Drawing.Size(460, 0);

            RadioButton[] radios = { rdoOption1, rdoOption2, rdoOption3, rdoOption4 };
            foreach (var rdo in radios)
            {
                rdo.BackColor = Color.FromArgb(99, 193, 209);
                rdo.ForeColor = Color.Black;
                rdo.Font = new Font("Consolas", 10, FontStyle.Bold);
            }

            btnNext.BackColor = Color.FromArgb(244, 196, 48);
            btnNext.ForeColor = Color.FromArgb(40, 40, 40);
            btnNext.Font = new Font("Consolas", 11, FontStyle.Bold);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.FlatAppearance.BorderSize = 1;
            btnNext.FlatAppearance.BorderColor = Color.Black;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            lblScore.BackColor = Color.Transparent;
            lblScore.Update();
        }
    }
}