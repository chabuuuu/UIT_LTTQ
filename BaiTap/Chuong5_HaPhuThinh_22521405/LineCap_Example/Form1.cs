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

namespace LineCap_Example
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
            Pen pen = new Pen(Color.Green);
            pen.Width = 4.0F;
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            pen.DashStyle = DashStyle.Dot;
            g.DrawLine(pen, 20.0F, 20.0F, 200.0F, 240.0F);
            g.DrawLine(pen, 200.0F, 240.0F, 160.0F, 20.0F);
            pen.DashStyle = DashStyle.Dash;
            Rectangle rect = new Rectangle(10, 10, 220, 260);
            g.DrawRectangle(pen, rect);

        }
    }
}
