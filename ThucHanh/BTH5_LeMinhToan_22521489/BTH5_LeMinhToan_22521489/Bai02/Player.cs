using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class Player
    {
        public Bitmap bitmap = Properties.Resources.player;
        public Point location;
        public Player(Point location)
        {
            this.location = location;
        }
        public Player(int X)
        {
            location.X = X;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y, bitmap.Width / 10, bitmap.Height/10);
        }
        public void Right()
        {
            location.X += 5;
        }
        public void Left()
        {
            location.X -= 5;
        }
    }
}
