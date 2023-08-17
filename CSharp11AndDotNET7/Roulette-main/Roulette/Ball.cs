using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Ball
    {
        public Point Center {  get; set; }
        public Color Color { get; set; }
        public static int Radius { get; set; } = 10;
        public float RotationAngle { get; set; }
        public float RotationSpeed { get; set; }

        public Ball(Point center)
        {
            Center = center;
            Color = Color.White;
            RotationAngle = 0;
            RotationSpeed = 7f;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }
        public void UpdatePosition()
        {
            RotationAngle += RotationSpeed;
            double radians = Math.PI * RotationAngle / 180;
            float centerX = 500 / 2; //500 is pictureBox width 
            float centerY = 500 / 2;  //500 is pictureBox height
            float newX = centerX + (float)(Math.Cos(radians) * 195);
            float newY = centerY + (float)(Math.Sin(radians) * 195);

            Center = new Point((int)newX, (int)newY);
        }
    }
}
