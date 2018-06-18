using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlarmClock
{
    [Serializable]
    class PacmanCircle
    {
        public enum DIRECTION
        {
            RIGHT,
            LEFT,
            UP,
            DOWN
        }

        public int X { set; get; }
        public int Y { get; set; }
        private DIRECTION Direction;
        public static readonly int Radius = 20;
        private int velocity;
        private bool isOpen;
        Brush brush;

        public PacmanCircle()
        {
            velocity = Radius;
            X = 7;
            Y = 5;
            Direction = DIRECTION.RIGHT;
            brush = new SolidBrush(Color.Yellow);
        }

        public void ChangeDirection(DIRECTION dir)
        {
            Direction = dir;
        }

        public void Move(int width, int height)
        {
            if (Direction == DIRECTION.RIGHT)
            {
                X += 1;
                if (X >= width)
                {
                    X = 0;
                }
            }

            if (Direction == DIRECTION.LEFT)
            {
                X -= 1;
                if (X < 0)
                {
                    X = width - 1;
                }
            }

            if (Direction == DIRECTION.UP)
            {
                Y -= 1;
                if (Y < 0)
                {
                    Y = height - 1;
                }
            }
            if (Direction == DIRECTION.DOWN)
            {
                Y += 1;
                if (Y >= height)
                {
                    Y = 0;
                }

            }
            isOpen = !isOpen;
        }

        public void Draw(Graphics g)
        {
            if (isOpen)
            {
                g.FillEllipse(brush, X * 2 * Radius, Y * 2 * Radius, Radius * 2, Radius * 2);
            }
            else
            {
                if (Direction == DIRECTION.RIGHT)
                {
                    g.FillPie(brush, X * 2 * Radius, Y * 2 * Radius, Radius * 2, Radius * 2, 45, 270);
                }
                else if (Direction == DIRECTION.LEFT)
                {
                    g.FillPie(brush, X * 2 * Radius, Y * 2 * Radius, Radius * 2, Radius * 2, 225, 270);
                }
                else if (Direction == DIRECTION.UP)
                {
                    g.FillPie(brush, X * 2 * Radius, Y * 2 * Radius, Radius * 2, Radius * 2, 315, 270);
                }
                else
                {
                    g.FillPie(brush, X * 2 * Radius, Y * 2 * Radius, Radius * 2, Radius * 2, 135, 270);
                }
            }
        }

    }
}
