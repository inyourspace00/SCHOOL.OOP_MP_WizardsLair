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

        // EASY button clicked (wired in designer as btnIT132_Click)
        private void btnIT132_Click(object sender, EventArgs e)
        {
            // Moves to Course Select next in the flow
            CourseSelectPage coursePage = new CourseSelectPage();
            coursePage.Show();
            this.Hide();
        }

        // HARD button clicked (wired in designer as btnHUM011_Click)
        private void btnHUM011_Click(object sender, EventArgs e)
        {
            // Moves to Course Select next in the flow
            CourseSelectPage coursePage = new CourseSelectPage();
            coursePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
        }

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {
        }
    }
}