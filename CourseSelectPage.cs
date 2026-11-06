using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
    public partial class CourseSelectPage : Form
    {
        private string difficulty;

        public CourseSelectPage(string selectedDifficulty = "EASY")
        {
            InitializeComponent();
            difficulty = selectedDifficulty;
            ConfigureCourses();
        }

        private void ConfigureCourses()
        {
            if (difficulty == "HARD")
            {
                btnIT132.Text = "CS151";
                btnHUM011.Text = "IT129";
                btnENV075.Text = "IT115";
            }
            else
            {
                btnIT132.Text = "IT132";
                btnHUM011.Text = "HUM011";
                btnENV075.Text = "ENV075";
            }
        }

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            DifficultyPage difficultyPage = Application.OpenForms
                .OfType<DifficultyPage>()
                .FirstOrDefault();

            if (difficultyPage == null)
            {
                difficultyPage = new DifficultyPage();
            }

            difficultyPage.Show();
            this.Close();
        }

        private void btnIT132_Click(object sender, EventArgs e)
        {
            string course = difficulty == "HARD" ? "CS151" : "IT132";
            QuizForm quiz = new QuizForm(course, difficulty);
            quiz.Show();
            this.Hide();
        }

        private void btnHUM011_Click(object sender, EventArgs e)
        {
            string course = difficulty == "HARD" ? "IT129" : "HUM011";
            QuizForm quiz = new QuizForm(course, difficulty);
            quiz.Show();
            this.Hide();
        }

        private void btnENV075_Click(object sender, EventArgs e)
        {
            string course = difficulty == "HARD" ? "IT115" : "ENV075";
            QuizForm quiz = new QuizForm(course, difficulty);
            quiz.Show();
            this.Hide();
        }
    }
}