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

namespace Clipping_Example
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
            Rectangle rect1 = new Rectangle(20, 20, 200, 200);
            Rectangle rect2 = new Rectangle(100, 100, 200, 200);
            Region rgn1 = new Region(rect1);
            Region rgn2 = new Region(rect2);
            g.SetClip(rgn1, CombineMode.Exclude);
            g.IntersectClip(rgn2);
            g.FillRectangle(Brushes.Red, 0, 0, 300, 300);
            g.ResetClip();
            g.DrawRectangle(Pens.Green, rect1);
            g.DrawRectangle(Pens.Yellow, rect2);
        }
    }
}
