using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine_DungContrustor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(20, 20);
            Point pt2 = new Point(10, 200);
            g.DrawLine(Pens.Red, pt1, pt2);
            int x1 = 40, y1 = 20, x2 = 200, y2 = 300;
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
        }
    }
    
}
