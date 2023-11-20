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

namespace DrawPath_Example
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
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(100, 50, 100, 100);
            path.AddLine(20, 20, 220, 80);
            path.AddLine(220, 80, 20, 80);
            path.AddLine(20, 80, 200, 140);
            Rectangle rect = new Rectangle(50, 150, 200, 80);
            path.AddRectangle(rect);
            g.DrawPath(Pens.Green, path);

        }
    }
}
