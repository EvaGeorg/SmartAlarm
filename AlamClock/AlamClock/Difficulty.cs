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
    public partial class Difficulty : Form
    {
        public static int Mode = 0;

        public Difficulty()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void difficultyBtn_Click(object sender, EventArgs e)
        {
            if (easy.Checked) Mode = 0;
            else if (medium.Checked) Mode = 1;
            else Mode = 2;

            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
