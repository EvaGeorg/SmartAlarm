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
    public partial class SolveEquation : Form
    {
        public int Result { get; set; }

        public SolveEquation()
        {
            InitializeComponent();
            this.ControlBox = false;
            startQuiz();
            op.BackColor = Color.White;
            num1.BackColor = Color.White;
            num2.BackColor = Color.White;


        }

        public void startQuiz()
        {
            Random random = new Random();

            int o = random.Next(4);
            if (o == 0) op.Text = "+";
            if (o == 1) op.Text = "-";
            if (o == 2) op.Text = "*";
            if (o == 3) op.Text = "/";

            int n1, n2, res;

            if (Difficulty.Mode == 0)
            {
                n1 = random.Next(10);
                n2 = random.Next(10);
            }
            else if(Difficulty.Mode == 1)
            {
                n1 = random.Next(25);
                n2 = random.Next(25);
            }
            else
            {
                n1 = random.Next(50);
                n2 = random.Next(50);
            }


            if (o == 0)
            {
                Result = n1 + n2;

            }
            if(o == 1)
            {
                if(n1 < n2)
                {
                    int tmp = n1;
                    n1 = n2;
                    n2 = tmp;
                }

                Result = n1 - n2;
            }
            if(o == 2)
            {
                Result = n1 * n2;
            }
            if(o == 3)
            {
                while (n2 == 0) n2 = random.Next();

                if (n1 % n2 != 0)
                {
                    int c = n1 % n2;
                    n1 -= c;
                }
                Result = n1 / n2;
            }

            num1.Text = n1.ToString();
            num2.Text = n2.ToString();
        }


       

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (Result.ToString() == resultUser.Text.Trim()) DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Wrong answer sleepy, try again!");
            }
        }
    }
}
