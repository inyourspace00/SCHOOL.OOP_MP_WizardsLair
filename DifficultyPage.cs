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

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnHUM011_Click(object sender, EventArgs e)
        {

        }

        private void btnIT132_Click(object sender, EventArgs e)
        {
            Form CourseSelectPage = new CourseSelectPage();
            CourseSelectPage.ShowDialog();
        }

        private void btnENV075_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
