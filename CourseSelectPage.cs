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
        public CourseSelectPage()
        {
            InitializeComponent();
        }

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIT132_Click(object sender, EventArgs e)
        {
            // Launches QuizForm for IT132
            QuizForm quiz = new QuizForm("IT132", "EASY"); // You can pass the selected difficulty here if you're tracking it
            quiz.Show();
            this.Hide();
        }

        private void btnHUM011_Click(object sender, EventArgs e)
        {
            // Launches QuizForm for HUM011
            QuizForm quiz = new QuizForm("HUM011", "EASY");
            quiz.Show();
            this.Hide();
        }

        private void btnENV075_Click(object sender, EventArgs e)
        {
            // Launches QuizForm for ENV075
            QuizForm quiz = new QuizForm("ENV075", "EASY");
            quiz.Show();
            this.Hide();
        }
    }
}