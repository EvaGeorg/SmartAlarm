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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            this.ControlBox = false;
            Difficulty difficulty = new Difficulty();
            difficulty.ShowDialog();

            if (difficulty.DialogResult == DialogResult.OK) difficulty.Close();
        }

        private void wordQuess_Click(object sender, EventArgs e)
        {
            GuessWordQuiz guessWordQuiz = new GuessWordQuiz();
            DialogResult dialogResult = guessWordQuiz.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                guessWordQuiz.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void equation_Click(object sender, EventArgs e)
        {
            SolveEquation solveEquation = new SolveEquation();
            DialogResult dialogResult = solveEquation.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                solveEquation.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void numbrGuess_Click(object sender, EventArgs e)
        {
            GuessNumberQuiz guessNumberQuiz = new GuessNumberQuiz();
            DialogResult dialogResult = guessNumberQuiz.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                guessNumberQuiz.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void guestionsBtn_Click(object sender, EventArgs e)
        {
            AnswerQuestion answerQuestion = new AnswerQuestion();
            DialogResult dialogResult = answerQuestion.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                answerQuestion.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
