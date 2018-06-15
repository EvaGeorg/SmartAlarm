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
    public partial class AnswerQuestion : Form
    {
        private Dictionary<string, string> mapQuestions;
        private Dictionary<int, string> mapInts;
        private string Answer1 = "";
        private string Answer2 = "";
        private static int Clicks = 0;

        public AnswerQuestion()
        {
            InitializeComponent();
            this.ControlBox = false;
            mapQuestions = new Dictionary<string, string>();
            mapInts = new Dictionary<int, string>();

            mapQuestions.Add("What is the capital city of Macedonia?", "Skopje"); // 1
            mapQuestions.Add("What is the capital city of the USA?", "Washington"); // 2
            mapQuestions.Add("What is the other measurement system, appart from Imperial?", "Metric"); // 3
            mapQuestions.Add("What is the animal that is an evolutionary ancestor of the human?", "Monkey"); // 4
            mapQuestions.Add("How many planets are there in the Solar System?", "8"); // 5
            mapQuestions.Add("How many continents are there on our planet?", "7"); // 6
            mapQuestions.Add("What is the most famous animal in Australia?", "Kangaroo"); // 7

            mapInts.Add(0, "What is the capital city of Macedonia?");
            mapInts.Add(1, "What is the capital city of the USA?");
            mapInts.Add(2, "What is the other measurement system, appart from Imperial?");
            mapInts.Add(3, "What is the animal that is an evolutionary ancestor of the human?");
            mapInts.Add(4, "How many planets are there in the Solar System?");
            mapInts.Add(5, "How many continents are there on our planet?");
            mapInts.Add(6, "What is the most famous animal in Australia?");

            AnswerGame();
        }

        public void AnswerGame()
        {
            Random random = new Random();

            int rand1 = random.Next(7);
            int rand2 = random.Next(7);

            while(rand1 == rand2)
            {
                rand2 = random.Next(7);
            }

            firstQ.Text = mapInts[rand1];
            secondQ.Text = mapInts[rand2];

            Answer1 = mapQuestions[firstQ.Text];
            Answer2 = mapQuestions[secondQ.Text];
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if(answer1.Text.Trim().ToLower() == Answer1.ToLower() && answer2.Text.Trim().ToLower() == Answer2.ToLower())
            {
                DialogResult = DialogResult.OK;
            }

            // way to ensure game ends eventually

            else
            {
                Clicks++;

                if (answer1.Text.Trim().ToLower() == Answer1.ToLower())
                {
                    if(Difficulty.Mode == 0)
                    {
                        if (Clicks > 3) MessageBox.Show("The first answer is correct! " + "The answer of second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("The first answer is correct, try answering the second differently!");
                    }
                    if (Difficulty.Mode == 1)
                    {
                        if (Clicks > 6) MessageBox.Show("The first answer is correct! " + "The answer of second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("The first answer is correct, try answering the second differently!");
                    }
                    if (Difficulty.Mode == 2)
                    {
                        if (Clicks > 9) MessageBox.Show("The first answer is correct! " + "The answer of second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("The first answer is correct, try answering the second differently!");
                    }
                }

                else if(answer2.Text.Trim().ToLower() == Answer2.ToLower())
                {
                    if (Difficulty.Mode == 0)
                    {
                        if (Clicks > 3) MessageBox.Show("The second answer is correct! " + "The answer of first question is: " + mapQuestions[firstQ.Text]);
                        else MessageBox.Show("The second answer is correct, try answering the first differently!");
                    }
                    if (Difficulty.Mode == 1)
                    {
                        if (Clicks > 6) MessageBox.Show("The second answer is correct! " + "The answer of first question is: " + mapQuestions[firstQ.Text]);
                        else MessageBox.Show("The second answer is correct, try answering the first differently!");
                    }
                    if (Difficulty.Mode == 2)
                    {
                        if (Clicks > 9) MessageBox.Show("The second answer is correct! " + "The answer of first question is: " + mapQuestions[firstQ.Text]);
                        else MessageBox.Show("The second answer is correct, try answering the first differently!");
                    }
                }

                else
                {
                    if (Difficulty.Mode == 0)
                    {
                        if (Clicks > 3) MessageBox.Show("The answer of first question is: " + mapQuestions[firstQ.Text] + " and the answer of the second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("Both answers are wrong, try answering differently!");
                    }
                    if (Difficulty.Mode == 1)
                    {
                        if (Clicks > 6) MessageBox.Show("The answer of first question is: " + mapQuestions[firstQ.Text] + " and the answer of the second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("Both answers are wrong, try answering differently!");
                    }
                    if (Difficulty.Mode == 2)
                    {
                        if (Clicks > 9) MessageBox.Show("The answer of first question is: " + mapQuestions[firstQ.Text] + " and the answer of the second question is: " + mapQuestions[secondQ.Text]);
                        else MessageBox.Show("Both answers are wrong, try answering differently!");
                    }
                }

            }           
        }
    }
}
