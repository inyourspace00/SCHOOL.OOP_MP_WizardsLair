using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_MachineProblem_WizardsLair
{
    public partial class LoginPage : Form
    {
        private const string FileName = "userData.txt";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //use this to check where userData.txt is stored
            //MessageBox.Show(Path.GetFullPath("userData.txt"));
            
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Account not found. Consider signing up for battle first.");
                return;
            }

            //bool flag that checks if user acc == existing records
            bool isAuthenticated = false;

            using (StreamReader sr = new StreamReader(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] credentials = line.Split(';');
                    if (credentials.Length ==2)
                    {
                        string savedUsername = credentials[0];
                        string savedPassword = credentials[1];

                        if (txtUsername.Text.Trim() == savedUsername &&
                            txtPassword.Text.Trim() == savedPassword)
                        {
                            isAuthenticated = true;
                            break;
                        }
                    }
                }
            }
            // if user has an account, open the next page
            if(isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (Form DifficultyPage = new DifficultyPage())
                {
                    DifficultyPage.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // text boxes cannot be empty when signing up
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields to sign up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (StreamWriter wr = new StreamWriter(FileName, true))
            {
                wr.WriteLine(username + ";" + password);
            }
            MessageBox.Show("Login successful!");
            
            txtPassword.Clear(); //clears inputs
            txtUsername.Clear();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
