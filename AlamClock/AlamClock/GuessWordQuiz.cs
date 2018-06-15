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
    public partial class GuessWordQuiz : Form
    {
        public static string[] words =
        {
            "coffee",
            "alarm",
            "sun",
            "shine",
            "work",
            "schedule",
            "sleep",
            "breakfast",
            "milk",
            "laziness"
        };

        public static int Guesses = 0;
        public static string word = words[0];

        public GuessWordQuiz()
        {
            InitializeComponent();
            this.ControlBox = false;
            PlayGame();
        }

        public void PlayGame()
        {
            Random random = new Random();
            int rand = random.Next(10);

            word = words[rand];

            string s = " ";


            if (Difficulty.Mode == 0)
            {
                for (int i=0; i<word.Length; i++)
                {
                    if (i % 2 == 0) s += word[i] + " ";
                    else s += "_ ";
                }
            }
            if(Difficulty.Mode == 1)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 3 == 0) s += word[i] + " ";
                    else s += "_ ";
                }
            }
            if(Difficulty.Mode == 2)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 4 == 0) s += word[i] + " ";
                    else s += "_ ";
                }
            }

            wordQuessMorning.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wordGuess.Text.Trim().ToLower() == word.ToLower()) DialogResult = DialogResult.OK;
            else
            {
                Guesses++;

                //Hints so that the word is eventually guessed in any case

                if(Guesses < 3)
                {
                    if (word == words[0]) MessageBox.Show("The word you are guessing is a beverage.");   //coffee
                    if (word == words[1]) MessageBox.Show("The word you are guessing is a loud object.");   //alarm
                    if (word == words[2]) MessageBox.Show("The word you are guessing is a yellow object.");   //sun
                    if (word == words[3]) MessageBox.Show("The word you are guessing is a related to the sun.");   //shine
                    if (word == words[4]) MessageBox.Show("The word you are guessing is an obligation.");   //work
                    if (word == words[5]) MessageBox.Show("The word you are guessing is a list of tasks.");   //schedule
                    if (word == words[6]) MessageBox.Show("The word you are guessing is an act of rest.");   //sleep
                    if (word == words[7]) MessageBox.Show("The word you are guessing is a meal in the day.");   //breakfast
                    if (word == words[8]) MessageBox.Show("The word you are guessing is a beverage.");   //milk
                    if (word == words[9]) MessageBox.Show("The word you are guessing is a human feature.");   //laziness

                }
                if (Guesses >= 3 && Guesses < 5)
                {
                    if (word == words[0]) MessageBox.Show("The word you are guessing is a drink to wake you up.");   //coffee
                    if (word == words[1]) MessageBox.Show("The word you are guessing is a loud object used to wake up.");   //alarm
                    if (word == words[2]) MessageBox.Show("The word you are guessing is a yellow object that shines.");   //sun
                    if (word == words[3]) MessageBox.Show("The word you are guessing is a related to the sun's appearance.");   //shine
                    if (word == words[4]) MessageBox.Show("The word you are guessing is an obligation or task people do.");   //work
                    if (word == words[5]) MessageBox.Show("The word you are guessing is an organized list of tasks.");   //schedule
                    if (word == words[6]) MessageBox.Show("The word you are guessing is an act of rest people do at night.");   //sleep
                    if (word == words[7]) MessageBox.Show("The word you are guessing is the first meal in the day.");   //breakfast
                    if (word == words[8]) MessageBox.Show("The word you are guessing is a beverage kids usually drink.");   //milk
                    if (word == words[9]) MessageBox.Show("The word you are guessing is a human feature that is opposite to productivity.");   //laziness
                }
                if(Guesses >= 5 && Guesses < 10)
                {
                    if (word == words[0]) MessageBox.Show("The word you are guessing is COFF - - .");   //coffee
                    if (word == words[1]) MessageBox.Show("The word you are guessing is ALA - - .");   //alarm
                    if (word == words[2]) MessageBox.Show("The word you are guessing is SU - .");   //sun
                    if (word == words[3]) MessageBox.Show("The word you are guessing is SHI - - .");   //shine
                    if (word == words[4]) MessageBox.Show("The word you are guessing is WO - - .");   //work
                    if (word == words[5]) MessageBox.Show("The word you are guessing is SCHEDU - - .");   //schedule
                    if (word == words[6]) MessageBox.Show("The word you are guessing is SLE - - .");   //sleep
                    if (word == words[7]) MessageBox.Show("The word you are guessing is BREAKFA - - .");   //breakfast
                    if (word == words[8]) MessageBox.Show("The word you are guessing is MI - - .");   //milk
                    if (word == words[9]) MessageBox.Show("The word you are guessing is LAZINE - - .");   //laziness
                }
                if(Guesses > 10)
                {
                    if (word == words[0]) MessageBox.Show("The word you are guessing is COFFEE.");   //coffee
                    if (word == words[1]) MessageBox.Show("The word you are guessing is ALARM.");   //alarm
                    if (word == words[2]) MessageBox.Show("The word you are guessing is SUN.");   //sun
                    if (word == words[3]) MessageBox.Show("The word you are guessing is SHINE.");   //shine
                    if (word == words[4]) MessageBox.Show("The word you are guessing is WORK.");   //work
                    if (word == words[5]) MessageBox.Show("The word you are guessing is SCHEDULE.");   //schedule
                    if (word == words[6]) MessageBox.Show("The word you are guessing is SLEEP.");   //sleep
                    if (word == words[7]) MessageBox.Show("The word you are guessing is a BREAKFAST.");   //breakfast
                    if (word == words[8]) MessageBox.Show("The word you are guessing is a MILK.");   //milk
                    if (word == words[9]) MessageBox.Show("The word you are guessing is a LAZINESS.");   //laziness
                }
            }
        }
    }
}
