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
    public class MiniGame : Form
    {
        private Label label1;
        private TextBox numberInput;
        private Button predictBtn;
        private Label mainText;
        private int[] gameData;
        private Label finalPredict;
        private readonly Random random = new Random();

        public bool Won { get; private set; }

        public MiniGame()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            gameData = new int[] { random.Next(1, 6) };
        }

        private void ClearGameData()
        {
            if (gameData != null)
            {
                Array.Clear(gameData, 0, gameData.Length);
                gameData = null;
            }
        }

        private void lblCourseSelect_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.mainText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.predictBtn = new System.Windows.Forms.Button();
            this.finalPredict = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.BackColor = System.Drawing.Color.Transparent;
            this.mainText.Font = new System.Drawing.Font("Gabriola", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.ForeColor = System.Drawing.Color.White;
            this.mainText.Location = new System.Drawing.Point(25, 27);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(381, 147);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "GUESS THE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number (1-5)";
            // 
            // numberInput
            // 
            this.numberInput.BackColor = System.Drawing.Color.Gold;
            this.numberInput.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.numberInput.Location = new System.Drawing.Point(50, 213);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(180, 53);
            this.numberInput.TabIndex = 2;
            this.numberInput.TextChanged += new System.EventHandler(this.numberInput_TextChanged);
            // 
            // predictBtn
            // 
            this.predictBtn.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.predictBtn.Location = new System.Drawing.Point(50, 284);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(146, 42);
            this.predictBtn.TabIndex = 3;
            this.predictBtn.Text = "Imagine";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // finalPredict
            // 
            this.finalPredict.AutoSize = true;
            this.finalPredict.BackColor = System.Drawing.Color.Transparent;
            this.finalPredict.Font = new System.Drawing.Font("Garamond", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPredict.ForeColor = System.Drawing.Color.Cornsilk;
            this.finalPredict.Location = new System.Drawing.Point(429, 213);
            this.finalPredict.Name = "finalPredict";
            this.finalPredict.Size = new System.Drawing.Size(0, 108);
            this.finalPredict.TabIndex = 4;
            this.finalPredict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalPredict.Click += new System.EventHandler(this.finalPredict_Click);
            // 
            // MiniGame
            // 
            this.BackgroundImage = global::OOP_MachineProblem_WizardsLair.Properties.Resources.MiniGameBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 482);
            this.Controls.Add(this.finalPredict);
            this.Controls.Add(this.predictBtn);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MiniGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void predictBtn_Click(object sender, EventArgs e)
        {
            int userNumber;

            if (!TryGetUserNumber(out userNumber))
            {
                return;
            }

            int generatedNumber = gameData[0];
            finalPredict.Text = generatedNumber.ToString();
            predictBtn.Enabled = false;
            numberInput.Enabled = false;

            await Task.Delay(2000);

            if (userNumber == generatedNumber)
            {
                Won = true;
                MessageBox.Show("You correctly guessed the number.", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearGameData();

                // guys for here add to open the MainPage form here after they won then game data has been cleared.
                Close();
            }
            else
            {
                MessageBox.Show("Wrong, the number is " + generatedNumber + ".", "Wrong Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearGameData();

                // then here for +1 health, idk how to implement it then close the MiniGame Form
                Close();
            }
        }

        private void numberInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberInput.Text))
            {
                return;
            }

            int userNumber;
            if (!int.TryParse(numberInput.Text, out userNumber) || userNumber < 1 || userNumber > 5)
            {
                MessageBox.Show("Please only enter 1 to 5.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberInput.Clear();
            }
        }

        private bool TryGetUserNumber(out int userNumber)
        {
            if (gameData == null || !int.TryParse(numberInput.Text, out userNumber) || userNumber < 1 || userNumber > 5)
            {
                MessageBox.Show("Please only enter 1 to 5.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userNumber = 0;
                return false;
            }

            return true;
        }

        private void finalPredict_Click(object sender, EventArgs e)
        {
         
        }
    }
}
