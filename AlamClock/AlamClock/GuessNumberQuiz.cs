using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    [Serializable]
    public partial class GuessNumberQuiz : Form
    {
        public int Number { get; set; }

        public GuessNumberQuiz()
        {
            InitializeComponent();
            this.ControlBox = false;
            guessLabel.ForeColor = Color.White;
            guessLabel.BackColor = Color.Transparent;
            Random random = new Random();

            if (Difficulty.Mode == 0)
            {
                Number = random.Next(11);
                guessLabel.Text = "You are guessing a number from 0 to 10!";
            }

            else if (Difficulty.Mode == 1)
            {
                Number = random.Next(21);
                guessLabel.Text = "You are guessing a number from 0 to 20!";
            }

            else if(Difficulty.Mode == 2)
            {
                Number = random.Next(31);
                guessLabel.Text = "You are guessing a number from 0 to 30!";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guessBox.Text.Trim().Length == 0) MessageBox.Show("Try to guess the number!");

            else
            {
                if (Number == int.Parse(guessBox.Text.Trim())) DialogResult = DialogResult.OK;
                else
                {
                    if (Number < int.Parse(guessBox.Text.Trim()))
                    {
                        MessageBox.Show("The secret number is smaller than your guess!");
                    }
                    else
                    {
                        MessageBox.Show("The secret number is greater than your guess!");
                    }
                }
            }
        }
    }
}
