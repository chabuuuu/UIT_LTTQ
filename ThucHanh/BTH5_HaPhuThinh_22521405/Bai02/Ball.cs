using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Ball
    {
        public Bitmap bitmap = Properties.Resources.ball;
        private Point location;

        public Point Location { get => location; set => location = value; }
        public Ball( Point location) 
        {
            Location = location;
        }   
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, Location.X,location.Y, bitmap.Width/10, bitmap.Height/10);
        }
        public void Down()
        {
            location.Y += 10;
        }
    }
}
