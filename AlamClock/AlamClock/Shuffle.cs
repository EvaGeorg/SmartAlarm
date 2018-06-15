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
    public partial class Shuffle : Form
    {
        public Shuffle()
        {
            InitializeComponent();
            this.ControlBox = false;
            Instructions instructions = new Instructions();
            DialogResult r = instructions.ShowDialog();
            if (r == DialogResult.OK) instructions.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }

            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
               
                DialogResult = DialogResult.OK;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }

            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }

            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }

            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }

            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }

            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

      

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }

            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }

            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }

            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }

            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") && (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") && (button7.Text == "7") && (button8.Text == "8") && (button9.Text == ""))
            {
                
                DialogResult = DialogResult.OK;
            }
        }
    }
}
