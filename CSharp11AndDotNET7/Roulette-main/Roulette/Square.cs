using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Square
    {
        public Point Center {  get; set; }
        public int Width { get; set; } = 45;
        public int Height { get; set; } = 45;

        public Color Color { get; set; }

        public bool Clicked { get; set; } = false;

        //1 red 2 black 3 green
        public int Type { get; set; }

        public int timesClicked { get; set; } = 0;

        public int Number { get; set; } = 1;

        public Square(Point center, int type, int number)
        {
            Center = center;
            Type = type;
            Number = number;
            if(Type == 1)
            {
                Color = Color.Red;
            }
            else if (Type == 2)
            {
                Color = Color.Black;
            }
            else
            {
                Color = Color.DarkGreen;
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Center.X - Width, Center.Y - Height, Width, Height);
            g.DrawRectangle(new Pen(Color.White, 2), Center.X - Width, Center.Y - Height, Width, Height);
            if(Number > 0)
            {
                g.DrawString(Number.ToString(), new Font("Arial", 15), new SolidBrush(Color.White), Center.X - Width + 10, Center.Y - Height + 5);

            }
            if (Number == 0)
            {
                g.DrawString(Number.ToString(), new Font("Arial", 15), new SolidBrush(Color.White), Center.X - Width + 55, Center.Y - Height + 10);
            }
            b.Dispose();
        }

        public bool isClicked(Point location)
        {
            Clicked = Math.Sqrt(Math.Pow(location.X - Center.X, 2) +  Math.Pow(location.Y - Center.Y, 2)) <= Width 
             || Math.Sqrt(Math.Pow(location.X - Center.X, 2) + Math.Pow(location.Y - Center.Y, 2)) <= Height;


            return Clicked;
        }
    }
}
