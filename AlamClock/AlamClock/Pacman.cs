using AlarmClock.Properties;
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
    public partial class Pacman : Form
    {

        Timer timer;
        PacmanCircle pacman;
        Graphics graphics;
        Bitmap doubleBuffer;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;

        public Pacman()
        {
            InitializeComponent();
            foodImage = Resources.food;
            newGame();
        }

        public void newGame()
        {
            pacman = new PacmanCircle();
            this.Width = PacmanCircle.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = PacmanCircle.Radius * 2 * (WORLD_HEIGHT + 1);
            doubleBuffer = new Bitmap(PacmanCircle.Radius * 2 * (WORLD_WIDTH + 1), PacmanCircle.Radius * 2 * (WORLD_HEIGHT + 1));
            graphics = CreateGraphics();
            Show();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TIMER_INTERVAL;
            timer.Start();
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    foodWorld[i][j] = true;
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            bool allEaten = true;
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (pacman.X == j && pacman.Y == i)
                    {
                        foodWorld[i][j] = false;
                    }
                    if (foodWorld[i][j])
                    {
                        allEaten = false;
                        g.DrawImageUnscaled(foodImage, j * PacmanCircle.Radius * 2 + (PacmanCircle.Radius * 2 - foodImage.Height) / 2, i * PacmanCircle.Radius * 2 + (PacmanCircle.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            pacman.Draw(g);
            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
            if (allEaten) {
                DialogResult = DialogResult.OK;
                this.Close(); }
        }



        private void Packman_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(PacmanCircle.DIRECTION.UP);
            }
            if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(PacmanCircle.DIRECTION.DOWN);
            }
            if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(PacmanCircle.DIRECTION.RIGHT);
            }
            if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(PacmanCircle.DIRECTION.LEFT);
            }
        }

        private void Pacman_Load(object sender, EventArgs e)
        {

        }
    }
}
