using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawRectangle_DungConstructor
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
            Rectangle rect = new Rectangle(10, 10, 100, 120);
            int x = 30, y = 40, width = 100, height = 50;
            g.DrawRectangle(Pens.Black, rect);
            g.DrawRectangle(Pens.Red, x, y, width, height);
        }
    }
}
