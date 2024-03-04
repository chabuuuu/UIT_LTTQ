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

namespace TaoDoiTuongPen_DungConstructor
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
            Pen p1 = new Pen(Color.Red);
            g.DrawRectangle(p1, new Rectangle(10, 30, 60, 60));

            Pen p2 = new Pen(Color.Orange, 5);
            g.DrawRectangle(p2, new Rectangle(80, 30, 60, 60));

            HatchBrush hb = new HatchBrush(HatchStyle.Wave, Color.Olive);
            Pen p3 = new Pen(hb, 20);
            g.DrawRectangle(p3, new Rectangle(160, 30, 60, 60));
        }
    }
}
