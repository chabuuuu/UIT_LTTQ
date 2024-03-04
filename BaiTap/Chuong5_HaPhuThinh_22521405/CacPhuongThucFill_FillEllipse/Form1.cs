using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacPhuongThucFill_FillEllipse
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
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Rectangle rect = new Rectangle(100, 120, 150, 150);
            g.FillEllipse(redBrush, rect);
            g.FillEllipse(greenBrush, 40, 40, 120, 140);
            g.FillEllipse(blueBrush, 60, 60, 90, 90);
        }
    }
}
