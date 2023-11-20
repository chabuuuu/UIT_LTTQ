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

namespace LinearGradientBrush_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Point pt1 = new Point(0, 10);
            Point pt2 = new Point(200, 10);
            LinearGradientBrush brush = new LinearGradientBrush(pt1,
            pt2, Color.Yellow, Color.Blue);
            e.Graphics.FillEllipse(brush, 0, 20, 200, 100);
            e.Graphics.FillRectangle(brush, 0, 160, 300, 200);
        }
    }
}
