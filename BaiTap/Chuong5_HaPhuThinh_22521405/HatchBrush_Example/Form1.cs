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

namespace HatchBrush_Example
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
            HatchStyle style = HatchStyle.BackwardDiagonal;
            Color forColor = Color.Red;
            Color bgrndColor = Color.Blue;
            HatchBrush brush = new HatchBrush(style, forColor,
            bgrndColor);
            g.FillRectangle(brush, 20, 20, 200, 200);
            style = HatchStyle.DarkVertical;
            forColor = Color.Green;
            bgrndColor = Color.Orange;
            brush = new HatchBrush(style, forColor, bgrndColor);
            g.FillRectangle(brush, 240, 20, 200, 200);
        }
    }
}
