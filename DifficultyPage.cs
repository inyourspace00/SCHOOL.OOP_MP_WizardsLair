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
    public partial class DifficultyPage : Form
    {
        public DifficultyPage()
        {
            InitializeComponent();
        }

        private void btnIT132_Click(object sender, EventArgs e)
        {
            CourseSelectPage coursePage = new CourseSelectPage("EASY");
            coursePage.Show();
            this.Hide();
        }

        private void btnHUM011_Click(object sender, EventArgs e)
        {
            CourseSelectPage coursePage = new CourseSelectPage("HARD");
            coursePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            CourseSelectPage coursePage = new CourseSelectPage("EASY");
            coursePage.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            CourseSelectPage coursePage = new CourseSelectPage("HARD");
            coursePage.Show();
            this.Hide();
        }

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {
        }
    }
}